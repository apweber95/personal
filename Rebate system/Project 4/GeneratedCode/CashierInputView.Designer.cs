namespace Project_4.GeneratedCode
{
    partial class CashierInputView
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
            this.uxNewTransaction = new System.Windows.Forms.Button();
            this.uxFinishTransaction = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxItemNameLabel = new System.Windows.Forms.Label();
            this.uxPriceLabel = new System.Windows.Forms.Label();
            this.uxQuantityLabel = new System.Windows.Forms.Label();
            this.uxItemName = new System.Windows.Forms.TextBox();
            this.uxQuantity = new System.Windows.Forms.NumericUpDown();
            this.uxPrice = new System.Windows.Forms.NumericUpDown();
            this.uxItemList = new System.Windows.Forms.ListBox();
            this.uxShoppingCartLabel = new System.Windows.Forms.Label();
            this.uxTransactionLabel = new System.Windows.Forms.Label();
            this.uxTransactionID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // uxNewTransaction
            // 
            this.uxNewTransaction.Location = new System.Drawing.Point(12, 12);
            this.uxNewTransaction.Name = "uxNewTransaction";
            this.uxNewTransaction.Size = new System.Drawing.Size(108, 23);
            this.uxNewTransaction.TabIndex = 0;
            this.uxNewTransaction.Text = "New Transaction";
            this.uxNewTransaction.UseVisualStyleBackColor = true;
            this.uxNewTransaction.Click += new System.EventHandler(this.uxNewTransaction_Click);
            // 
            // uxFinishTransaction
            // 
            this.uxFinishTransaction.Location = new System.Drawing.Point(157, 230);
            this.uxFinishTransaction.Name = "uxFinishTransaction";
            this.uxFinishTransaction.Size = new System.Drawing.Size(108, 23);
            this.uxFinishTransaction.TabIndex = 1;
            this.uxFinishTransaction.Text = "Finish Transaction";
            this.uxFinishTransaction.UseVisualStyleBackColor = true;
            this.uxFinishTransaction.Click += new System.EventHandler(this.uxFinishTransaction_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(79, 182);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(90, 23);
            this.uxAdd.TabIndex = 2;
            this.uxAdd.Text = "Add Item";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxItemNameLabel
            // 
            this.uxItemNameLabel.AutoSize = true;
            this.uxItemNameLabel.Location = new System.Drawing.Point(12, 61);
            this.uxItemNameLabel.Name = "uxItemNameLabel";
            this.uxItemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.uxItemNameLabel.TabIndex = 3;
            this.uxItemNameLabel.Text = "Item Name:";
            // 
            // uxPriceLabel
            // 
            this.uxPriceLabel.AutoSize = true;
            this.uxPriceLabel.Location = new System.Drawing.Point(12, 102);
            this.uxPriceLabel.Name = "uxPriceLabel";
            this.uxPriceLabel.Size = new System.Drawing.Size(56, 13);
            this.uxPriceLabel.TabIndex = 4;
            this.uxPriceLabel.Text = "Unit Price:";
            // 
            // uxQuantityLabel
            // 
            this.uxQuantityLabel.AutoSize = true;
            this.uxQuantityLabel.Location = new System.Drawing.Point(12, 138);
            this.uxQuantityLabel.Name = "uxQuantityLabel";
            this.uxQuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.uxQuantityLabel.TabIndex = 5;
            this.uxQuantityLabel.Text = "Quantity:";
            // 
            // uxItemName
            // 
            this.uxItemName.Location = new System.Drawing.Point(79, 58);
            this.uxItemName.Name = "uxItemName";
            this.uxItemName.Size = new System.Drawing.Size(105, 20);
            this.uxItemName.TabIndex = 6;
            this.uxItemName.TextChanged += new System.EventHandler(this.uxItemName_TextChanged);
            // 
            // uxQuantity
            // 
            this.uxQuantity.Location = new System.Drawing.Point(79, 136);
            this.uxQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxQuantity.Name = "uxQuantity";
            this.uxQuantity.Size = new System.Drawing.Size(41, 20);
            this.uxQuantity.TabIndex = 8;
            this.uxQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxPrice
            // 
            this.uxPrice.DecimalPlaces = 2;
            this.uxPrice.Location = new System.Drawing.Point(79, 100);
            this.uxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uxPrice.Name = "uxPrice";
            this.uxPrice.Size = new System.Drawing.Size(54, 20);
            this.uxPrice.TabIndex = 9;
            // 
            // uxItemList
            // 
            this.uxItemList.FormattingEnabled = true;
            this.uxItemList.HorizontalScrollbar = true;
            this.uxItemList.Location = new System.Drawing.Point(267, 66);
            this.uxItemList.Name = "uxItemList";
            this.uxItemList.Size = new System.Drawing.Size(182, 147);
            this.uxItemList.TabIndex = 10;
            // 
            // uxShoppingCartLabel
            // 
            this.uxShoppingCartLabel.AutoSize = true;
            this.uxShoppingCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxShoppingCartLabel.Location = new System.Drawing.Point(294, 39);
            this.uxShoppingCartLabel.Name = "uxShoppingCartLabel";
            this.uxShoppingCartLabel.Size = new System.Drawing.Size(130, 24);
            this.uxShoppingCartLabel.TabIndex = 11;
            this.uxShoppingCartLabel.Text = "Shopping Cart";
            // 
            // uxTransactionLabel
            // 
            this.uxTransactionLabel.AutoSize = true;
            this.uxTransactionLabel.Location = new System.Drawing.Point(126, 17);
            this.uxTransactionLabel.Name = "uxTransactionLabel";
            this.uxTransactionLabel.Size = new System.Drawing.Size(76, 13);
            this.uxTransactionLabel.TabIndex = 12;
            this.uxTransactionLabel.Text = "Transaction #:";
            // 
            // uxTransactionID
            // 
            this.uxTransactionID.AutoSize = true;
            this.uxTransactionID.Location = new System.Drawing.Point(208, 17);
            this.uxTransactionID.Name = "uxTransactionID";
            this.uxTransactionID.Size = new System.Drawing.Size(0, 13);
            this.uxTransactionID.TabIndex = 14;
            // 
            // CashierInputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 265);
            this.Controls.Add(this.uxTransactionID);
            this.Controls.Add(this.uxTransactionLabel);
            this.Controls.Add(this.uxShoppingCartLabel);
            this.Controls.Add(this.uxItemList);
            this.Controls.Add(this.uxPrice);
            this.Controls.Add(this.uxQuantity);
            this.Controls.Add(this.uxItemName);
            this.Controls.Add(this.uxQuantityLabel);
            this.Controls.Add(this.uxPriceLabel);
            this.Controls.Add(this.uxItemNameLabel);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxFinishTransaction);
            this.Controls.Add(this.uxNewTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CashierInputView";
            this.Text = "CashierView";
            ((System.ComponentModel.ISupportInitialize)(this.uxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxNewTransaction;
        private System.Windows.Forms.Button uxFinishTransaction;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Label uxItemNameLabel;
        private System.Windows.Forms.Label uxPriceLabel;
        private System.Windows.Forms.Label uxQuantityLabel;
        private System.Windows.Forms.TextBox uxItemName;
        private System.Windows.Forms.NumericUpDown uxQuantity;
        private System.Windows.Forms.NumericUpDown uxPrice;
        private System.Windows.Forms.ListBox uxItemList;
        private System.Windows.Forms.Label uxShoppingCartLabel;
        private System.Windows.Forms.Label uxTransactionLabel;
        private System.Windows.Forms.Label uxTransactionID;
    }
}