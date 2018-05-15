namespace TrackerUI
{
    partial class TournamentsDashboard
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loadExistingTourDropdown = new System.Windows.Forms.ComboBox();
            this.loadexistingTournBtn = new System.Windows.Forms.Button();
            this.createTournBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.Location = new System.Drawing.Point(26, 35);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(305, 40);
            this.createPrizeLabel.TabIndex = 4;
            this.createPrizeLabel.Text = "Tournament Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Load Existing Tournament";
            // 
            // loadExistingTourDropdown
            // 
            this.loadExistingTourDropdown.FormattingEnabled = true;
            this.loadExistingTourDropdown.Location = new System.Drawing.Point(64, 135);
            this.loadExistingTourDropdown.Name = "loadExistingTourDropdown";
            this.loadExistingTourDropdown.Size = new System.Drawing.Size(264, 24);
            this.loadExistingTourDropdown.TabIndex = 16;
            // 
            // loadexistingTournBtn
            // 
            this.loadexistingTournBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loadexistingTournBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadexistingTournBtn.Location = new System.Drawing.Point(85, 179);
            this.loadexistingTournBtn.Name = "loadexistingTournBtn";
            this.loadexistingTournBtn.Size = new System.Drawing.Size(197, 34);
            this.loadexistingTournBtn.TabIndex = 21;
            this.loadexistingTournBtn.Text = "Load Tournament";
            this.loadexistingTournBtn.UseVisualStyleBackColor = false;
            // 
            // createTournBtn
            // 
            this.createTournBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createTournBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournBtn.Location = new System.Drawing.Point(64, 237);
            this.createTournBtn.Name = "createTournBtn";
            this.createTournBtn.Size = new System.Drawing.Size(235, 39);
            this.createTournBtn.TabIndex = 22;
            this.createTournBtn.Text = "Create Tournament";
            this.createTournBtn.UseVisualStyleBackColor = false;
            this.createTournBtn.Click += new System.EventHandler(this.createTournBtn_Click);
            // 
            // TournamentsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(372, 330);
            this.Controls.Add(this.createTournBtn);
            this.Controls.Add(this.loadexistingTournBtn);
            this.Controls.Add(this.loadExistingTourDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createPrizeLabel);
            this.Name = "TournamentsDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox loadExistingTourDropdown;
        private System.Windows.Forms.Button loadexistingTournBtn;
        private System.Windows.Forms.Button createTournBtn;
    }
}