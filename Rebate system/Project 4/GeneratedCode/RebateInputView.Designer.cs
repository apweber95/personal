namespace Project_4.GeneratedCode
{
    partial class RebateInputView
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
            this.uxRebateAmount = new System.Windows.Forms.NumericUpDown();
            this.uxRebateAmountLabel = new System.Windows.Forms.Label();
            this.uxTransactionNumLabel = new System.Windows.Forms.Label();
            this.uxTransactionNumber = new System.Windows.Forms.NumericUpDown();
            this.uxEnterRebateButton = new System.Windows.Forms.Button();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDate = new System.Windows.Forms.TextBox();
            this.uxGenerateRebates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxRebateAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRebateAmount
            // 
            this.uxRebateAmount.Location = new System.Drawing.Point(122, 7);
            this.uxRebateAmount.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.uxRebateAmount.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.uxRebateAmount.Name = "uxRebateAmount";
            this.uxRebateAmount.Size = new System.Drawing.Size(54, 20);
            this.uxRebateAmount.TabIndex = 0;
            this.uxRebateAmount.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // uxRebateAmountLabel
            // 
            this.uxRebateAmountLabel.AutoSize = true;
            this.uxRebateAmountLabel.Location = new System.Drawing.Point(12, 9);
            this.uxRebateAmountLabel.Name = "uxRebateAmountLabel";
            this.uxRebateAmountLabel.Size = new System.Drawing.Size(104, 13);
            this.uxRebateAmountLabel.TabIndex = 1;
            this.uxRebateAmountLabel.Text = "Rebate Amount (%) :";
            // 
            // uxTransactionNumLabel
            // 
            this.uxTransactionNumLabel.AutoSize = true;
            this.uxTransactionNumLabel.Location = new System.Drawing.Point(12, 40);
            this.uxTransactionNumLabel.Name = "uxTransactionNumLabel";
            this.uxTransactionNumLabel.Size = new System.Drawing.Size(109, 13);
            this.uxTransactionNumLabel.TabIndex = 3;
            this.uxTransactionNumLabel.Text = "Transaction Number :";
            // 
            // uxTransactionNumber
            // 
            this.uxTransactionNumber.Location = new System.Drawing.Point(122, 38);
            this.uxTransactionNumber.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.uxTransactionNumber.Name = "uxTransactionNumber";
            this.uxTransactionNumber.Size = new System.Drawing.Size(54, 20);
            this.uxTransactionNumber.TabIndex = 2;
            // 
            // uxEnterRebateButton
            // 
            this.uxEnterRebateButton.Location = new System.Drawing.Point(197, 4);
            this.uxEnterRebateButton.Name = "uxEnterRebateButton";
            this.uxEnterRebateButton.Size = new System.Drawing.Size(75, 79);
            this.uxEnterRebateButton.TabIndex = 4;
            this.uxEnterRebateButton.Text = "Enter Rebate";
            this.uxEnterRebateButton.UseVisualStyleBackColor = true;
            this.uxEnterRebateButton.Click += new System.EventHandler(this.uxEnterRebateButton_Click);
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(12, 66);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(82, 13);
            this.uxDateLabel.TabIndex = 7;
            this.uxDateLabel.Text = "Date (1/1/18)  :";
            // 
            // uxDate
            // 
            this.uxDate.Location = new System.Drawing.Point(100, 63);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(76, 20);
            this.uxDate.TabIndex = 8;
            // 
            // uxGenerateRebates
            // 
            this.uxGenerateRebates.Location = new System.Drawing.Point(12, 92);
            this.uxGenerateRebates.Name = "uxGenerateRebates";
            this.uxGenerateRebates.Size = new System.Drawing.Size(260, 23);
            this.uxGenerateRebates.TabIndex = 9;
            this.uxGenerateRebates.Text = "Generate Rebates";
            this.uxGenerateRebates.UseVisualStyleBackColor = true;
            this.uxGenerateRebates.Click += new System.EventHandler(this.uxGenerateRebates_Click);
            // 
            // RebateInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.uxGenerateRebates);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxDateLabel);
            this.Controls.Add(this.uxEnterRebateButton);
            this.Controls.Add(this.uxTransactionNumLabel);
            this.Controls.Add(this.uxTransactionNumber);
            this.Controls.Add(this.uxRebateAmountLabel);
            this.Controls.Add(this.uxRebateAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RebateInputView";
            this.Text = "RebateView";
            ((System.ComponentModel.ISupportInitialize)(this.uxRebateAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxRebateAmount;
        private System.Windows.Forms.Label uxRebateAmountLabel;
        private System.Windows.Forms.Label uxTransactionNumLabel;
        private System.Windows.Forms.NumericUpDown uxTransactionNumber;
        private System.Windows.Forms.Button uxEnterRebateButton;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.TextBox uxDate;
        private System.Windows.Forms.Button uxGenerateRebates;
    }
}