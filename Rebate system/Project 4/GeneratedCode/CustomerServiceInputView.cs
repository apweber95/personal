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
    public partial class uxReturnList : Form
    {
        private ReturnsManager.ReturnHandler returnHandler;
        private ReturnsManager.EndReturnHandler endHandler;

        public uxReturnList(ReturnsManager.ReturnHandler h, ReturnsManager.EndReturnHandler e)
        {
            returnHandler = h;
            InitializeComponent();
            endHandler = e;
            uxAddReturnButton.Enabled = false;


        }

        /// <summary>
        /// Runs when user wants to add an item to return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            string message = "0 items returned.";
            int q = (int)uxQuantity.Value;
            while ( q > 0)
            {
                message = returnHandler(uxItemName.Text, (int)uxTransactionNum.Value);
                q--;
            }
            MessageBox.Show(message);
           



        }

     

        private void uxTransactionNum_ValueChanged(object sender, EventArgs e)
        {
            uxAddReturnButton.Enabled = true;

        }

        /// <summary>
        /// Completes the return transaction and resets the customer service view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFinishReturn_Click_1(object sender, EventArgs e)
        {
            endHandler((int)uxTransactionNum.Value);
            uxTransactionNum.Value = 0;
            uxAddReturnButton.Enabled = false;
            uxQuantity.Value = 0;
            uxFinishReturn.Enabled = false;
            

        }
    }
}
