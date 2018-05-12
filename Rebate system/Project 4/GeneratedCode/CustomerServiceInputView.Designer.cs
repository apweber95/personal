namespace Project_4.GeneratedCode
{
    partial class uxReturnList
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
            this.uxTransactionNum = new System.Windows.Forms.NumericUpDown();
            this.uxTransactionNumLabel = new System.Windows.Forms.Label();
            this.uxAddReturnButton = new System.Windows.Forms.Button();
            this.uxFinishReturn = new System.Windows.Forms.Button();
            this.uxQuantity = new System.Windows.Forms.NumericUpDown();
            this.uxItemNameLabel = new System.Windows.Forms.Label();
            this.uxItemName = new System.Windows.Forms.TextBox();
            this.uxQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTransactionNum
            // 
            this.uxTransactionNum.Location = new System.Drawing.Point(124, 7);
            this.uxTransactionNum.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.uxTransactionNum.Name = "uxTransactionNum";
            this.uxTransactionNum.Size = new System.Drawing.Size(50, 20);
            this.uxTransactionNum.TabIndex = 0;
            this.uxTransactionNum.ValueChanged += new System.EventHandler(this.uxTransactionNum_ValueChanged);
            // 
            // uxTransactionNumLabel
            // 
            this.uxTransactionNumLabel.AutoSize = true;
            this.uxTransactionNumLabel.Location = new System.Drawing.Point(12, 9);
            this.uxTransactionNumLabel.Name = "uxTransactionNumLabel";
            this.uxTransactionNumLabel.Size = new System.Drawing.Size(106, 13);
            this.uxTransactionNumLabel.TabIndex = 1;
            this.uxTransactionNumLabel.Text = "Transaction Number:";
            // 
            // uxAddReturnButton
            // 
            this.uxAddReturnButton.Location = new System.Drawing.Point(180, 7);
            this.uxAddReturnButton.Name = "uxAddReturnButton";
            this.uxAddReturnButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddReturnButton.TabIndex = 2;
            this.uxAddReturnButton.Text = "Return Item";
            this.uxAddReturnButton.UseVisualStyleBackColor = true;
            this.uxAddReturnButton.Click += new System.EventHandler(this.uxReturnButton_Click);
            // 
            // uxFinishReturn
            // 
            this.uxFinishReturn.Location = new System.Drawing.Point(261, 7);
            this.uxFinishReturn.Name = "uxFinishReturn";
            this.uxFinishReturn.Size = new System.Drawing.Size(85, 23);
            this.uxFinishReturn.TabIndex = 3;
            this.uxFinishReturn.Text = "Finish Return";
            this.uxFinishReturn.UseVisualStyleBackColor = true;
            this.uxFinishReturn.Click += new System.EventHandler(this.uxFinishReturn_Click_1);
            // 
            // uxQuantity
            // 
            this.uxQuantity.Location = new System.Drawing.Point(82, 96);
            this.uxQuantity.Name = "uxQuantity";
            this.uxQuantity.Size = new System.Drawing.Size(50, 20);
            this.uxQuantity.TabIndex = 6;
            // 
            // uxItemNameLabel
            // 
            this.uxItemNameLabel.AutoSize = true;
            this.uxItemNameLabel.Location = new System.Drawing.Point(12, 59);
            this.uxItemNameLabel.Name = "uxItemNameLabel";
            this.uxItemNameLabel.Size = new System.Drawing.Size(64, 13);
            this.uxItemNameLabel.TabIndex = 8;
            this.uxItemNameLabel.Text = "Item Name :";
            // 
            // uxItemName
            // 
            this.uxItemName.Location = new System.Drawing.Point(82, 56);
            this.uxItemName.Name = "uxItemName";
            this.uxItemName.Size = new System.Drawing.Size(59, 20);
            this.uxItemName.TabIndex = 9;
            // 
            // uxQuantityLabel
            // 
            this.uxQuantityLabel.AutoSize = true;
            this.uxQuantityLabel.Location = new System.Drawing.Point(12, 98);
            this.uxQuantityLabel.Name = "uxQuantityLabel";
            this.uxQuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.uxQuantityLabel.TabIndex = 10;
            this.uxQuantityLabel.Text = "Quantity:";
            // 
            // uxReturnList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 139);
            this.Controls.Add(this.uxQuantityLabel);
            this.Controls.Add(this.uxItemName);
            this.Controls.Add(this.uxItemNameLabel);
            this.Controls.Add(this.uxQuantity);
            this.Controls.Add(this.uxFinishReturn);
            this.Controls.Add(this.uxAddReturnButton);
            this.Controls.Add(this.uxTransactionNumLabel);
            this.Controls.Add(this.uxTransactionNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "uxReturnList";
            this.Text = "CustomerServiceView";
            ((System.ComponentModel.ISupportInitialize)(this.uxTransactionNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxTransactionNum;
        private System.Windows.Forms.Label uxTransactionNumLabel;
        private System.Windows.Forms.Button uxAddReturnButton;
        private System.Windows.Forms.Button uxFinishReturn;
        private System.Windows.Forms.NumericUpDown uxQuantity;
        private System.Windows.Forms.Label uxItemNameLabel;
        private System.Windows.Forms.TextBox uxItemName;
        private System.Windows.Forms.Label uxQuantityLabel;
    }
}