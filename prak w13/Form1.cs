using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prak_w13
{
    public partial class FormDataPlayer : Form
    {
        public FormDataPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dataTablePlayer = new DataTable();
        DataTable dataTableNation = new DataTable();
        DataTable dataTableTeam = new DataTable();
        int posisi2 = 0;
        string teamAwal;
        string noTeamAwal;

        private void FormDataPlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "select * from player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTablePlayer);

            sqlQuery = "select n.nation as `Nationality`, p.nationality_id as Negara from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTableNation);
            comboBoxNation.DataSource = dataTableNation;
            comboBoxNation.DisplayMember = "Nationality";
            comboBoxNation.ValueMember = "Negara";

            sqlQuery = "select t.team_name as `Team`, p.team_id as Tim from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTableTeam);
            comboBoxTeam.DataSource = dataTableTeam;
            comboBoxTeam.DisplayMember = "Team";
            comboBoxTeam.ValueMember = "Tim";

            PlayerData(0);
        }

        public void PlayerData(int posisi)
        {
            textBoxID.Text = dataTablePlayer.Rows[posisi][0].ToString();
            nudTeamNo.Text = dataTablePlayer.Rows[posisi][1].ToString();
            textBoxName.Text = dataTablePlayer.Rows[posisi][2].ToString();
            dtpBirthDate.Text = dataTablePlayer.Rows[posisi][7].ToString();
            comboBoxNation.SelectedValue = dataTablePlayer.Rows[posisi][3].ToString();
            comboBoxTeam.SelectedValue = dataTablePlayer.Rows[posisi][8].ToString();
            teamAwal = comboBoxTeam.Text;
            noTeamAwal = nudTeamNo.Value.ToString();
            posisi2 = posisi;
        }

        private void buttonFData_Click(object sender, EventArgs e)
        {
            PlayerData(0);
        }

        private void buttonLData_Click(object sender, EventArgs e)
        {
            PlayerData(dataTablePlayer.Rows.Count - 1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (posisi2 == 0)
            {
                MessageBox.Show("This Data is The First Data");
            }
            else
            {
                posisi2--;
                PlayerData(posisi2);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (posisi2 < dataTablePlayer.Rows.Count - 1)
            {
                posisi2++;
                PlayerData(posisi2);
            }
            else
            {
                MessageBox.Show("This Data is The Last Data");
            }
        }
        DataTable dataTableTeamNo = new DataTable();
        public static int cek = 0;
        private void nudTeamNo_ValueChanged(object sender, EventArgs e)
        {
            sqlQuery = $"select team_number from player where team_id = '" + comboBoxTeam.SelectedValue.ToString() + "' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dataTableTeamNo);

            for (int i = 0; i < dataTableTeamNo.Rows.Count; i++)
            {
                if (nudTeamNo.Value.ToString() == dataTableTeamNo.Rows[i][0].ToString())
                {
                    cek++;
                }
            }
            if (cek == 0)
            {
                labelStatusTeamNo.Text = "Available";
                buttonSave.Enabled = true;
            }
            else
            {
                labelStatusTeamNo.Text = "Not Available";
                buttonSave.Enabled = false;
            }
            cek = 0;
            dataTableTeamNo.Clear();
        }
        DataTable dataTableCapt = new DataTable();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (labelStatusTeamNo.Text == "Available")
            {
                sqlQuery = $"update player set player_name = '" + textBoxName.Text + "', team_number = '" + nudTeamNo.Value.ToString() + "', nationality_id = '" + comboBoxNation.SelectedValue.ToString() + "', team_id = '" + comboBoxTeam.SelectedValue.ToString() + "' where player_id = '" + textBoxID.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Your Data is Saved!");
            }
            else
            {
                MessageBox.Show("Team Number is Not Available");
            }

            if (comboBoxTeam.Text != teamAwal)
            {
                cek = 0;
                sqlQuery = $"select p.player_id, p.player_name from player p, team t where t.captain_id = p.player_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataTableCapt);

                for (int i = 0; i < dataTableCapt.Rows.Count; i++)
                {
                    if (textBoxID.Text == dataTableCapt.Rows[i][0].ToString())
                    {
                        cek++;
                    }
                }
                if (cek > 0)
                {
                    /*sqlQuery = $"select * from player where '" + teamAwal + "' = ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dataTableCapt);*/
                }
                dataTableCapt.Clear();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
