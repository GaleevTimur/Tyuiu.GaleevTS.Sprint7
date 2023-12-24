using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GaleevTS.Sprint7.Lib;
namespace Tyuiu.GaleevTS.Sprint7
{
    public partial class FormAddToData : Form
    {
        private FormMain mainForm;
        public FormAddToData(FormMain form)
        {
            InitializeComponent();
            mainForm = form; 
        }
        DataService ds = new DataService();
        private void button_ToAddData_GTS_Click(object sender, EventArgs e)
        {
            string costOfFilm = ds.GetCost(textBox_LengthFilm_GTS.Text);
            string[] rowData = new string[] { textBox_NameFilm_GTS.Text, textBox_CodeFilm_GTS.Text, textBox_LengthFilm_GTS.Text, textBox_DateFilm_GTS.Text, textBox_GenreFilm_GTS.Text, textBox_ActorFIlm_GTS.Text, costOfFilm };



            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string[] GetRowData()
        {
            string costOfFilm = ds.GetCost(textBox_LengthFilm_GTS.Text);
            return new string[] { textBox_NameFilm_GTS.Text, textBox_CodeFilm_GTS.Text, textBox_LengthFilm_GTS.Text, textBox_DateFilm_GTS.Text, textBox_GenreFilm_GTS.Text, textBox_ActorFIlm_GTS.Text, costOfFilm };
        }
    }
}
