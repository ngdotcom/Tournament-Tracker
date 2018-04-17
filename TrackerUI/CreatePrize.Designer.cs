namespace TrackerUI
{
    partial class CreatePrize
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
            this.placeNumValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.priceAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.pricePercentageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createPriceBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(174, 40);
            this.createPrizeLabel.TabIndex = 3;
            this.createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumValue
            // 
            this.placeNumValue.Location = new System.Drawing.Point(142, 70);
            this.placeNumValue.Name = "placeNumValue";
            this.placeNumValue.Size = new System.Drawing.Size(100, 22);
            this.placeNumValue.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 75);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 17);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(142, 108);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(100, 22);
            this.placeNameValue.TabIndex = 14;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(16, 113);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(84, 17);
            this.placeNameLabel.TabIndex = 13;
            this.placeNameLabel.Text = "Place Name";
            // 
            // priceAmountValue
            // 
            this.priceAmountValue.Location = new System.Drawing.Point(142, 151);
            this.priceAmountValue.Name = "priceAmountValue";
            this.priceAmountValue.Size = new System.Drawing.Size(100, 22);
            this.priceAmountValue.TabIndex = 16;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Location = new System.Drawing.Point(16, 154);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(92, 17);
            this.prizeAmountLabel.TabIndex = 15;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(142, 225);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(100, 22);
            this.prizePercentageValue.TabIndex = 18;
            // 
            // pricePercentageLabel
            // 
            this.pricePercentageLabel.AutoSize = true;
            this.pricePercentageLabel.Location = new System.Drawing.Point(16, 230);
            this.pricePercentageLabel.Name = "pricePercentageLabel";
            this.pricePercentageLabel.Size = new System.Drawing.Size(117, 17);
            this.pricePercentageLabel.TabIndex = 17;
            this.pricePercentageLabel.Text = "Price Percentage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "-or-";
            // 
            // createPriceBtn
            // 
            this.createPriceBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createPriceBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPriceBtn.Location = new System.Drawing.Point(71, 276);
            this.createPriceBtn.Name = "createPriceBtn";
            this.createPriceBtn.Size = new System.Drawing.Size(148, 34);
            this.createPriceBtn.TabIndex = 20;
            this.createPriceBtn.Text = "Create Price";
            this.createPriceBtn.UseVisualStyleBackColor = false;
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(292, 349);
            this.Controls.Add(this.createPriceBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.pricePercentageLabel);
            this.Controls.Add(this.priceAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumValue);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Name = "CreatePrize";
            this.Text = "CreatePrize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox placeNumValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox priceAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label pricePercentageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createPriceBtn;
    }
}