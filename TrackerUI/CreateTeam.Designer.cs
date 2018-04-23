namespace TrackerUI
{
    partial class CreateTeam
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameText = new System.Windows.Forms.TextBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.addTeamMemBtn = new System.Windows.Forms.Button();
            this.addNewMemberBox = new System.Windows.Forms.GroupBox();
            this.createMemBtn = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMemListbox = new System.Windows.Forms.ListBox();
            this.deleteMemBtn = new System.Windows.Forms.Button();
            this.createTemBtn = new System.Windows.Forms.Button();
            this.addNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.Location = new System.Drawing.Point(12, 26);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(185, 40);
            this.createTeamLabel.TabIndex = 2;
            this.createTeamLabel.Text = "Create Team:";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(16, 86);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(85, 17);
            this.teamNameLabel.TabIndex = 10;
            this.teamNameLabel.Text = "Team Name";
            // 
            // teamNameText
            // 
            this.teamNameText.Location = new System.Drawing.Point(19, 106);
            this.teamNameText.Name = "teamNameText";
            this.teamNameText.Size = new System.Drawing.Size(264, 22);
            this.teamNameText.TabIndex = 11;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(16, 144);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(142, 17);
            this.selectTeamMemberLabel.TabIndex = 12;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(19, 164);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(264, 24);
            this.selectTeamMemberDropdown.TabIndex = 15;
            // 
            // addTeamMemBtn
            // 
            this.addTeamMemBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addTeamMemBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamMemBtn.Location = new System.Drawing.Point(67, 203);
            this.addTeamMemBtn.Name = "addTeamMemBtn";
            this.addTeamMemBtn.Size = new System.Drawing.Size(148, 40);
            this.addTeamMemBtn.TabIndex = 17;
            this.addTeamMemBtn.Text = "Add Member";
            this.addTeamMemBtn.UseVisualStyleBackColor = false;
            // 
            // addNewMemberBox
            // 
            this.addNewMemberBox.Controls.Add(this.createMemBtn);
            this.addNewMemberBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberBox.Controls.Add(this.label2);
            this.addNewMemberBox.Controls.Add(this.emailValue);
            this.addNewMemberBox.Controls.Add(this.emailLabel);
            this.addNewMemberBox.Controls.Add(this.lastNameValue);
            this.addNewMemberBox.Controls.Add(this.label1);
            this.addNewMemberBox.Controls.Add(this.firstNameValue);
            this.addNewMemberBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberBox.Location = new System.Drawing.Point(19, 263);
            this.addNewMemberBox.Name = "addNewMemberBox";
            this.addNewMemberBox.Size = new System.Drawing.Size(264, 195);
            this.addNewMemberBox.TabIndex = 18;
            this.addNewMemberBox.TabStop = false;
            this.addNewMemberBox.Text = "Add New Member";
            // 
            // createMemBtn
            // 
            this.createMemBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createMemBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMemBtn.Location = new System.Drawing.Point(35, 143);
            this.createMemBtn.Name = "createMemBtn";
            this.createMemBtn.Size = new System.Drawing.Size(148, 34);
            this.createMemBtn.TabIndex = 18;
            this.createMemBtn.Text = "Create Member";
            this.createMemBtn.UseVisualStyleBackColor = false;
            this.createMemBtn.Click += new System.EventHandler(this.createMemBtn_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(87, 115);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(100, 22);
            this.cellphoneValue.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cell Phone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(87, 87);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(100, 22);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 92);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(87, 59);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(100, 22);
            this.lastNameValue.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(87, 30);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(100, 22);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 35);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMemListbox
            // 
            this.teamMemListbox.FormattingEnabled = true;
            this.teamMemListbox.ItemHeight = 16;
            this.teamMemListbox.Location = new System.Drawing.Point(321, 75);
            this.teamMemListbox.Name = "teamMemListbox";
            this.teamMemListbox.Size = new System.Drawing.Size(290, 340);
            this.teamMemListbox.TabIndex = 19;
            // 
            // deleteMemBtn
            // 
            this.deleteMemBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteMemBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemBtn.Location = new System.Drawing.Point(321, 26);
            this.deleteMemBtn.Name = "deleteMemBtn";
            this.deleteMemBtn.Size = new System.Drawing.Size(219, 40);
            this.deleteMemBtn.TabIndex = 20;
            this.deleteMemBtn.Text = "Delete Selected Member";
            this.deleteMemBtn.UseVisualStyleBackColor = false;
            // 
            // createTemBtn
            // 
            this.createTemBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createTemBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemBtn.Location = new System.Drawing.Point(392, 421);
            this.createTemBtn.Name = "createTemBtn";
            this.createTemBtn.Size = new System.Drawing.Size(148, 40);
            this.createTemBtn.TabIndex = 21;
            this.createTemBtn.Text = "Create Team";
            this.createTemBtn.UseVisualStyleBackColor = false;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(746, 470);
            this.Controls.Add(this.createTemBtn);
            this.Controls.Add(this.deleteMemBtn);
            this.Controls.Add(this.teamMemListbox);
            this.Controls.Add(this.addNewMemberBox);
            this.Controls.Add(this.addTeamMemBtn);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameText);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.addNewMemberBox.ResumeLayout(false);
            this.addNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameText;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Button addTeamMemBtn;
        private System.Windows.Forms.GroupBox addNewMemberBox;
        private System.Windows.Forms.Button createMemBtn;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMemListbox;
        private System.Windows.Forms.Button deleteMemBtn;
        private System.Windows.Forms.Button createTemBtn;
    }
}