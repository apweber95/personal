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
    public partial class uxForm : Form
    {
        public delegate void Observer(int id);
        public Observer run;

        private Database database;

        public uxForm(Database d)
        {
            InitializeComponent();
            run = new Observer(update);
            database = d;
        }

        public void update(int id)
        {
            Rebate rebate = database.getRebate(id);
            MessageBox.Show(rebate.ToString());
        }
    }
}
