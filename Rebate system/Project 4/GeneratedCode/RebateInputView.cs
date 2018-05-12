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
    public partial class RebateInputView : Form
    {
        private RebateManager.EnterRebateHandler enterRebateHandle;
        private RebateManager.GenRebateHandler genRebateHandle;

        public RebateInputView(RebateManager.EnterRebateHandler r, RebateManager.GenRebateHandler g)
        {
            enterRebateHandle = r;
            genRebateHandle = g;
            InitializeComponent();
        }

        private void uxEnterRebateButton_Click(object sender, EventArgs e)
        {
            DateTime enteredDate = DateTime.Parse(uxDate.Text);
            enterRebateHandle((int)uxTransactionNumber.Value, enteredDate); 
        }

        private void uxGenerateRebates_Click(object sender, EventArgs e)
        {
            genRebateHandle();
        }
    }
}
