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
    public partial class RebateOutputView : Form
    {
        public delegate void Observer(bool valid);
        public Observer run;

        public RebateOutputView(Database d)
        {
            InitializeComponent();
            run = new Observer(update);
        }

        public void update(bool valid)
        {
            if (valid)
            {
                MessageBox.Show("Valid rebate entered");
            }
            else
            {
                MessageBox.Show("Invalid rebate entered");
            }
        }
    }
}
