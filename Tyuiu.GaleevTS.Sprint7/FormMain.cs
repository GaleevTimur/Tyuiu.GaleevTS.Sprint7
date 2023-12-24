using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GaleevTS.Sprint7.Lib;

namespace Tyuiu.GaleevTS.Sprint7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonInfo_GTS_Click(object sender, EventArgs e)
        {
            FormAboutProgramm formAbout = new FormAboutProgramm();
            formAbout.ShowDialog();
        }

        private void buttonImportCSV_GTS_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv";
            saveFileDialog.FileName = "Архив фильмов.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    saveFileDialogFilmData_GTS.FileName = "Архив фильмов.csv";
                    saveFileDialogFilmData_GTS.InitialDirectory = Directory.GetCurrentDirectory();
                    saveFileDialog.ShowDialog();

                    string path = saveFileDialog.FileName;
                    FileInfo fileInfo = new FileInfo(path);
                    bool fileExists = fileInfo.Exists;

                    if (fileExists)
                    {
                        File.Delete(path);
                    }

                    int rows = dataGridViewClips_GTS.RowCount;
                    int colums = dataGridViewClips_GTS.ColumnCount;


                    string str = "";

                    for (int j = 0; j < colums; j++)
                    {
                        if (j != colums - 1)
                        {
                            str = str + dataGridViewClips_GTS.Columns[j].HeaderText + ";";
                        }
                        else
                        {
                            str = str + dataGridViewClips_GTS.Columns[j].HeaderText;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding("Windows-1251"));
                    str = "";

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < colums; j++)
                        {
                            if (j != colums - 1)
                            {
                                str = str + dataGridViewClips_GTS.Rows[i].Cells[j].Value + ";";
                            }
                            else
                            {
                                str = str + dataGridViewClips_GTS.Rows[i].Cells[j].Value;
                            }
                        }
                        File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding("Windows-1251"));
                        str = "";
                    }

                    MessageBox.Show("Таблица успешно сохранена в формате CSV.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при сохранении таблицы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.Default);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;

        }
        private void LoadDataIntoDataGridView(string filePath)
        {
            string[,] dataArray = LoadFromFileData(filePath);

            dataGridViewClips_GTS.Rows.Clear();
            dataGridViewClips_GTS.Columns.Clear();

            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewClips_GTS.Columns.Add("", dataArray[0, i]);
            }

            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewClips_GTS.Rows.Add(rowData.ToArray());
            }
            foreach (DataGridViewColumn column in dataGridViewClips_GTS.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridViewClips_GTS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        

        private void buttonFAQ_GTS_Click(object sender, EventArgs e)
        {
            FormAboutMe formAbout = new FormAboutMe();
            formAbout.ShowDialog();
        }

        private void buttonToDownloadData_GTS_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_GTS = new OpenFileDialog();
            openFileDialog_GTS.Filter = "csv Files|*.csv";
            if (openFileDialog_GTS.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_GTS.FileName;

                LoadDataIntoDataGridView(filePath);
            }
            button_AddToData_GTS.Enabled = true;
            button_Stat_GTS.Enabled = true;
        }

        private void button_AddToData_GTS_Click_1(object sender, EventArgs e)
        {
            FormAddToData inputForm = new FormAddToData(this);
            if (inputForm.ShowDialog() == DialogResult.OK)
            {

                string[] rowData = inputForm.GetRowData();


                dataGridViewClips_GTS.Rows.Add(rowData);
            }
            buttonImportCSV_GTS.Enabled = true;
        }
        private void textBoxSearch_KeyDown_GTS(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = textBoxSearch_GTS.Text;

                PerformSearch(searchTerm);
            }
        }
        private void PerformSearch(string searchTerm)
        {

            bool containsDigits = searchTerm.Any(char.IsDigit);

            foreach (DataGridViewRow row in dataGridViewClips_GTS.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (containsDigits && cell.Value != null && cell.Value.ToString().Equals(searchTerm))
                    {
                        row.Selected = true;
                        dataGridViewClips_GTS.CurrentCell = cell;
                        return;
                    }
                    else if (!containsDigits && cell.Value != null && cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        dataGridViewClips_GTS.CurrentCell = cell;
                        return;
                    }
                }
            }

            MessageBox.Show("Ничего не найдено.", "Поиск");
        }


        private void button_Stat_GTS_Click(object sender, EventArgs e)
        {
            List<string> columnValuesCost = new List<string>();

            foreach (DataGridViewRow row in dataGridViewClips_GTS.Rows)
            {
                if (row.Cells.Count > 6 && row.Cells[6].Value != null)
                {
                    columnValuesCost.Add(row.Cells[6].Value.ToString());
                }
            }

            string[] columnArrayCostSum = columnValuesCost.ToArray();
            string sumOfCost = ds.GetAllSum(columnArrayCostSum);

            List<string> columnValuesLength = new List<string>();

            foreach (DataGridViewRow row in dataGridViewClips_GTS.Rows)
            {
                if (row.Cells.Count > 2 && row.Cells[2].Value != null)
                {
                    columnValuesLength.Add(row.Cells[2].Value.ToString());
                }
            }

            string[] columnArrayLengthSum = columnValuesLength.ToArray();
            string sumOfLength = ds.GetAllLength(columnArrayLengthSum);

            FormStat formStat = new FormStat();

            formStat.FirstTextBoxValue = sumOfCost;
            formStat.SecondTextBoxValue = sumOfLength;

            formStat.Show();
        }
    }

}


