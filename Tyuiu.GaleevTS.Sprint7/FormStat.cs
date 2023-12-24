using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GaleevTS.Sprint7
{
    public partial class FormStat : Form
    {
        public string FirstTextBoxValue
        {
            set
            {
                textBoxStatOfSum_GTS.Text = value;
            }
        }

        public string SecondTextBoxValue
        {
            set
            {
                textBoxStatOfLength_GTS.Text = value;
            }
        }
        public FormStat()
        {
            InitializeComponent();
        }

        private void buttonCloseStat_GTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
