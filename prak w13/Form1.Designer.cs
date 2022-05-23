
namespace prak_w13
{
    partial class FormDataPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFData = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLData = new System.Windows.Forms.Button();
            this.labelPlayerID = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelNation = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelTeamNo = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelStatusTeamNo = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.nudTeamNo = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamNo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFData
            // 
            this.buttonFData.Location = new System.Drawing.Point(83, 63);
            this.buttonFData.Name = "buttonFData";
            this.buttonFData.Size = new System.Drawing.Size(85, 51);
            this.buttonFData.TabIndex = 0;
            this.buttonFData.Text = "<<";
            this.buttonFData.UseVisualStyleBackColor = true;
            this.buttonFData.Click += new System.EventHandler(this.buttonFData_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(323, 63);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(85, 51);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(202, 63);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(85, 51);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLData
            // 
            this.buttonLData.Location = new System.Drawing.Point(438, 63);
            this.buttonLData.Name = "buttonLData";
            this.buttonLData.Size = new System.Drawing.Size(85, 51);
            this.buttonLData.TabIndex = 3;
            this.buttonLData.Text = ">>";
            this.buttonLData.UseVisualStyleBackColor = true;
            this.buttonLData.Click += new System.EventHandler(this.buttonLData_Click);
            // 
            // labelPlayerID
            // 
            this.labelPlayerID.AutoSize = true;
            this.labelPlayerID.Location = new System.Drawing.Point(48, 150);
            this.labelPlayerID.Name = "labelPlayerID";
            this.labelPlayerID.Size = new System.Drawing.Size(73, 20);
            this.labelPlayerID.TabIndex = 4;
            this.labelPlayerID.Text = "Player ID";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(48, 189);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(98, 20);
            this.labelPlayerName.TabIndex = 5;
            this.labelPlayerName.Text = "Player Name";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(48, 227);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(81, 20);
            this.labelBirthDate.TabIndex = 6;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // labelNation
            // 
            this.labelNation.AutoSize = true;
            this.labelNation.Location = new System.Drawing.Point(48, 266);
            this.labelNation.Name = "labelNation";
            this.labelNation.Size = new System.Drawing.Size(82, 20);
            this.labelNation.TabIndex = 7;
            this.labelNation.Text = "Nationality";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(48, 305);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(49, 20);
            this.labelTeam.TabIndex = 8;
            this.labelTeam.Text = "Team";
            // 
            // labelTeamNo
            // 
            this.labelTeamNo.AutoSize = true;
            this.labelTeamNo.Location = new System.Drawing.Point(48, 344);
            this.labelTeamNo.Name = "labelTeamNo";
            this.labelTeamNo.Size = new System.Drawing.Size(109, 20);
            this.labelTeamNo.TabIndex = 9;
            this.labelTeamNo.Text = "Team Number";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(52, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(251, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(309, 386);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(251, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelStatusTeamNo
            // 
            this.labelStatusTeamNo.AutoSize = true;
            this.labelStatusTeamNo.Location = new System.Drawing.Point(413, 348);
            this.labelStatusTeamNo.Name = "labelStatusTeamNo";
            this.labelStatusTeamNo.Size = new System.Drawing.Size(72, 20);
            this.labelStatusTeamNo.TabIndex = 12;
            this.labelStatusTeamNo.Text = "Available";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(200, 150);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(164, 26);
            this.textBoxID.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 189);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(234, 26);
            this.textBoxName.TabIndex = 14;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(200, 227);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(323, 26);
            this.dtpBirthDate.TabIndex = 15;
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(200, 305);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(234, 28);
            this.comboBoxTeam.TabIndex = 17;
            // 
            // nudTeamNo
            // 
            this.nudTeamNo.Location = new System.Drawing.Point(200, 342);
            this.nudTeamNo.Name = "nudTeamNo";
            this.nudTeamNo.Size = new System.Drawing.Size(164, 26);
            this.nudTeamNo.TabIndex = 18;
            this.nudTeamNo.ValueChanged += new System.EventHandler(this.nudTeamNo_ValueChanged);
            // 
            // comboBoxNation
            // 
            this.comboBoxNation.FormattingEnabled = true;
            this.comboBoxNation.Location = new System.Drawing.Point(200, 263);
            this.comboBoxNation.Name = "comboBoxNation";
            this.comboBoxNation.Size = new System.Drawing.Size(234, 28);
            this.comboBoxNation.TabIndex = 19;
            // 
            // FormDataPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxNation);
            this.Controls.Add(this.nudTeamNo);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelStatusTeamNo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTeamNo);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelNation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelPlayerID);
            this.Controls.Add(this.buttonLData);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFData);
            this.Name = "FormDataPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormDataPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTeamNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFData;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLData;
        private System.Windows.Forms.Label labelPlayerID;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelNation;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelTeamNo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelStatusTeamNo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.NumericUpDown nudTeamNo;
        private System.Windows.Forms.ComboBox comboBoxNation;
    }
}

