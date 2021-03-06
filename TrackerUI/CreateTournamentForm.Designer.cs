﻿namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameText = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeText = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLabelLink = new System.Windows.Forms.LinkLabel();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.tournamentTeamsListbox = new System.Windows.Forms.ListBox();
            this.teamNplayersLabel = new System.Windows.Forms.Label();
            this.removeSelectedPrizesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedPlayersbtn = new System.Windows.Forms.Button();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 31);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(262, 40);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "Create Tournament:";
            // 
            // tournamentNameText
            // 
            this.tournamentNameText.Location = new System.Drawing.Point(19, 115);
            this.tournamentNameText.Name = "tournamentNameText";
            this.tournamentNameText.Size = new System.Drawing.Size(264, 39);
            this.tournamentNameText.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Location = new System.Drawing.Point(13, 80);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(244, 32);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeText
            // 
            this.entryFeeText.Location = new System.Drawing.Point(154, 177);
            this.entryFeeText.Name = "entryFeeText";
            this.entryFeeText.Size = new System.Drawing.Size(129, 39);
            this.entryFeeText.TabIndex = 12;
            this.entryFeeText.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Location = new System.Drawing.Point(13, 184);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(135, 32);
            this.entryFeeLabel.TabIndex = 11;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Location = new System.Drawing.Point(13, 247);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(166, 32);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(19, 282);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(264, 40);
            this.selectTeamDropdown.TabIndex = 14;
            // 
            // createNewTeamLabelLink
            // 
            this.createNewTeamLabelLink.AutoSize = true;
            this.createNewTeamLabelLink.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLabelLink.Location = new System.Drawing.Point(176, 258);
            this.createNewTeamLabelLink.Name = "createNewTeamLabelLink";
            this.createNewTeamLabelLink.Size = new System.Drawing.Size(137, 19);
            this.createNewTeamLabelLink.TabIndex = 15;
            this.createNewTeamLabelLink.TabStop = true;
            this.createNewTeamLabelLink.Text = "Create New Team";
            this.createNewTeamLabelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLabelLink_LinkClicked);
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addTeamBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamBtn.Location = new System.Drawing.Point(78, 328);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(148, 40);
            this.addTeamBtn.TabIndex = 16;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = false;
            this.addTeamBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createPrizeBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeBtn.Location = new System.Drawing.Point(78, 386);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(148, 40);
            this.createPrizeBtn.TabIndex = 17;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = false;
            this.createPrizeBtn.Click += new System.EventHandler(this.createPrizeBtn_Click);
            // 
            // tournamentTeamsListbox
            // 
            this.tournamentTeamsListbox.FormattingEnabled = true;
            this.tournamentTeamsListbox.ItemHeight = 32;
            this.tournamentTeamsListbox.Location = new System.Drawing.Point(348, 44);
            this.tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            this.tournamentTeamsListbox.Size = new System.Drawing.Size(364, 196);
            this.tournamentTeamsListbox.TabIndex = 18;
            // 
            // teamNplayersLabel
            // 
            this.teamNplayersLabel.AutoSize = true;
            this.teamNplayersLabel.Location = new System.Drawing.Point(342, 9);
            this.teamNplayersLabel.Name = "teamNplayersLabel";
            this.teamNplayersLabel.Size = new System.Drawing.Size(197, 32);
            this.teamNplayersLabel.TabIndex = 19;
            this.teamNplayersLabel.Text = "Team / Players";
            // 
            // removeSelectedPrizesBtn
            // 
            this.removeSelectedPrizesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removeSelectedPrizesBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizesBtn.Location = new System.Drawing.Point(741, 386);
            this.removeSelectedPrizesBtn.Name = "removeSelectedPrizesBtn";
            this.removeSelectedPrizesBtn.Size = new System.Drawing.Size(111, 67);
            this.removeSelectedPrizesBtn.TabIndex = 20;
            this.removeSelectedPrizesBtn.Text = "Remove Selected";
            this.removeSelectedPrizesBtn.UseVisualStyleBackColor = false;
            this.removeSelectedPrizesBtn.Click += new System.EventHandler(this.removeSelectedPrizesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 32;
            this.prizesListBox.Location = new System.Drawing.Point(348, 299);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(364, 228);
            this.prizesListBox.TabIndex = 21;
            // 
            // removeSelectedPlayersbtn
            // 
            this.removeSelectedPlayersbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.removeSelectedPlayersbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPlayersbtn.Location = new System.Drawing.Point(741, 117);
            this.removeSelectedPlayersbtn.Name = "removeSelectedPlayersbtn";
            this.removeSelectedPlayersbtn.Size = new System.Drawing.Size(127, 60);
            this.removeSelectedPlayersbtn.TabIndex = 23;
            this.removeSelectedPlayersbtn.Text = "Remove Selected ";
            this.removeSelectedPlayersbtn.UseVisualStyleBackColor = false;
            this.removeSelectedPlayersbtn.Click += new System.EventHandler(this.removeSelectedPlayersbtn_Click);
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.Location = new System.Drawing.Point(245, 544);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(313, 46);
            this.createTournamentBtn.TabIndex = 24;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            this.createTournamentBtn.Click += new System.EventHandler(this.createTournamentBtn_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1038, 602);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.removeSelectedPlayersbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.removeSelectedPrizesBtn);
            this.Controls.Add(this.teamNplayersLabel);
            this.Controls.Add(this.tournamentTeamsListbox);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.createNewTeamLabelLink);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeText);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameText);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox tournamentNameText;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeText;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.LinkLabel createNewTeamLabelLink;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.Button createPrizeBtn;
        private System.Windows.Forms.ListBox tournamentTeamsListbox;
        private System.Windows.Forms.Label teamNplayersLabel;
        private System.Windows.Forms.Button removeSelectedPrizesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button removeSelectedPlayersbtn;
        private System.Windows.Forms.Button createTournamentBtn;
    }
}