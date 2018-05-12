using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.GeneratedCode
{
    public partial class CashierInputView : Form
    {
        private SalesManager.TransactionHandler transHandler;
        private SalesManager.ItemHandler itemHandler;
        private SalesManager.EndTransactionHandler endTransaction;
        private int transactionID = 0;
        public CashierInputView(SalesManager.TransactionHandler h, SalesManager.ItemHandler i, SalesManager.EndTransactionHandler e)
        {
            transHandler = h;
            itemHandler = i;
            endTransaction = e;
            InitializeComponent();
            uxAdd.Enabled = false;
            uxFinishTransaction.Enabled = false;
            uxItemName.Enabled = false;
            uxPrice.Enabled = false;
            uxQuantity.Enabled = false;
            uxItemList.Items.Add(" Item          Price         Quantity");

        }

        private void uxNewTransaction_Click(object sender, EventArgs e)
        {
            uxFinishTransaction.Enabled = true;
            uxItemName.Enabled = true;
            uxPrice.Enabled = true;
            uxQuantity.Enabled = true;
            uxNewTransaction.Enabled = false;
            transactionID++;
            uxTransactionID.Text = transactionID.ToString();
            transHandler(transactionID);
        }

        private void uxFinishTransaction_Click(object sender, EventArgs e)
        {
            uxFinishTransaction.Enabled = false;
            uxItemName.Enabled = false;
            uxPrice.Enabled = false;
            uxQuantity.Enabled = false;
            uxNewTransaction.Enabled = true;
            uxItemName.Clear();
            uxPrice.Value = 0;
            uxQuantity.Value = 1;
            uxItemList.Items.Clear();
            uxItemList.Items.Add(" Item          Price         Quantity");
            endTransaction();

        }

        private void uxItemName_TextChanged(object sender, EventArgs e)
        {
            uxAdd.Enabled = true;
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            itemHandler((int)uxQuantity.Value, (float)uxPrice.Value, uxItemName.Text);
            uxAdd.Enabled = false;
           string price = string.Format("{0:C2}", uxPrice.Value);
            uxItemList.Items.Add( "  "+uxItemName.Text +"          " + price + "            " + uxQuantity.Value.ToString());
            uxItemName.Clear();

        }

    }
}
