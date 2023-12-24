
namespace Tyuiu.GaleevTS.Sprint7
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_Grid_GTS = new System.Windows.Forms.Panel();
            this.dataGridViewClips_GTS = new System.Windows.Forms.DataGridView();
            this.panel_info_GTS = new System.Windows.Forms.Panel();
            this.groupBoxSearch_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxSearch_GTS = new System.Windows.Forms.TextBox();
            this.saveFileDialogFilmData_GTS = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_GTS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GTS = new System.Windows.Forms.ToolTip(this.components);
            this.button_Stat_GTS = new System.Windows.Forms.Button();
            this.buttonImportCSV_GTS = new System.Windows.Forms.Button();
            this.buttonToDownloadData_GTS = new System.Windows.Forms.Button();
            this.buttonInfo_GTS = new System.Windows.Forms.Button();
            this.button_AddToData_GTS = new System.Windows.Forms.Button();
            this.buttonFAQ_GTS = new System.Windows.Forms.Button();
            this.panel_Grid_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClips_GTS)).BeginInit();
            this.panel_info_GTS.SuspendLayout();
            this.groupBoxSearch_GTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Grid_GTS
            // 
            this.panel_Grid_GTS.Controls.Add(this.dataGridViewClips_GTS);
            this.panel_Grid_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Grid_GTS.Location = new System.Drawing.Point(0, 80);
            this.panel_Grid_GTS.Name = "panel_Grid_GTS";
            this.panel_Grid_GTS.Size = new System.Drawing.Size(931, 359);
            this.panel_Grid_GTS.TabIndex = 5;
            // 
            // dataGridViewClips_GTS
            // 
            this.dataGridViewClips_GTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClips_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClips_GTS.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClips_GTS.Name = "dataGridViewClips_GTS";
            this.dataGridViewClips_GTS.Size = new System.Drawing.Size(931, 359);
            this.dataGridViewClips_GTS.TabIndex = 0;
            // 
            // panel_info_GTS
            // 
            this.panel_info_GTS.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel_info_GTS.Controls.Add(this.button_Stat_GTS);
            this.panel_info_GTS.Controls.Add(this.groupBoxSearch_GTS);
            this.panel_info_GTS.Controls.Add(this.buttonImportCSV_GTS);
            this.panel_info_GTS.Controls.Add(this.buttonToDownloadData_GTS);
            this.panel_info_GTS.Controls.Add(this.buttonInfo_GTS);
            this.panel_info_GTS.Controls.Add(this.button_AddToData_GTS);
            this.panel_info_GTS.Controls.Add(this.buttonFAQ_GTS);
            this.panel_info_GTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info_GTS.Location = new System.Drawing.Point(0, 0);
            this.panel_info_GTS.Name = "panel_info_GTS";
            this.panel_info_GTS.Size = new System.Drawing.Size(931, 80);
            this.panel_info_GTS.TabIndex = 4;
            // 
            // groupBoxSearch_GTS
            // 
            this.groupBoxSearch_GTS.Controls.Add(this.textBoxSearch_GTS);
            this.groupBoxSearch_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSearch_GTS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearch_GTS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSearch_GTS.Location = new System.Drawing.Point(383, 12);
            this.groupBoxSearch_GTS.Name = "groupBoxSearch_GTS";
            this.groupBoxSearch_GTS.Size = new System.Drawing.Size(290, 48);
            this.groupBoxSearch_GTS.TabIndex = 8;
            this.groupBoxSearch_GTS.TabStop = false;
            this.groupBoxSearch_GTS.Text = "Поиск:";
            // 
            // textBoxSearch_GTS
            // 
            this.textBoxSearch_GTS.Location = new System.Drawing.Point(6, 22);
            this.textBoxSearch_GTS.Name = "textBoxSearch_GTS";
            this.textBoxSearch_GTS.Size = new System.Drawing.Size(278, 24);
            this.textBoxSearch_GTS.TabIndex = 0;
            this.textBoxSearch_GTS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown_GTS);
            // 
            // openFileDialog_GTS
            // 
            this.openFileDialog_GTS.FileName = "openFileDialog1";
            // 
            // toolTip_GTS
            // 
            this.toolTip_GTS.IsBalloon = true;
            this.toolTip_GTS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_GTS.ToolTipTitle = "Подсказка";
            // 
            // button_Stat_GTS
            // 
            this.button_Stat_GTS.BackColor = System.Drawing.Color.Coral;
            this.button_Stat_GTS.Enabled = false;
            this.button_Stat_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stat_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.chart_bar;
            this.button_Stat_GTS.Location = new System.Drawing.Point(682, 16);
            this.button_Stat_GTS.Name = "button_Stat_GTS";
            this.button_Stat_GTS.Size = new System.Drawing.Size(117, 49);
            this.button_Stat_GTS.TabIndex = 9;
            this.toolTip_GTS.SetToolTip(this.button_Stat_GTS, "Статистика по таблице");
            this.button_Stat_GTS.UseVisualStyleBackColor = false;
            this.button_Stat_GTS.Click += new System.EventHandler(this.button_Stat_GTS_Click);
            // 
            // buttonImportCSV_GTS
            // 
            this.buttonImportCSV_GTS.BackColor = System.Drawing.Color.Coral;
            this.buttonImportCSV_GTS.Enabled = false;
            this.buttonImportCSV_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportCSV_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.table_go;
            this.buttonImportCSV_GTS.Location = new System.Drawing.Point(260, 13);
            this.buttonImportCSV_GTS.Name = "buttonImportCSV_GTS";
            this.buttonImportCSV_GTS.Size = new System.Drawing.Size(117, 49);
            this.buttonImportCSV_GTS.TabIndex = 6;
            this.toolTip_GTS.SetToolTip(this.buttonImportCSV_GTS, "Сохранить таблицу");
            this.buttonImportCSV_GTS.UseVisualStyleBackColor = false;
            this.buttonImportCSV_GTS.Click += new System.EventHandler(this.buttonImportCSV_GTS_Click);
            // 
            // buttonToDownloadData_GTS
            // 
            this.buttonToDownloadData_GTS.BackColor = System.Drawing.Color.Coral;
            this.buttonToDownloadData_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToDownloadData_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.table_add;
            this.buttonToDownloadData_GTS.Location = new System.Drawing.Point(12, 13);
            this.buttonToDownloadData_GTS.Name = "buttonToDownloadData_GTS";
            this.buttonToDownloadData_GTS.Size = new System.Drawing.Size(118, 49);
            this.buttonToDownloadData_GTS.TabIndex = 5;
            this.toolTip_GTS.SetToolTip(this.buttonToDownloadData_GTS, "Загрузить таблицу");
            this.buttonToDownloadData_GTS.UseVisualStyleBackColor = false;
            this.buttonToDownloadData_GTS.Click += new System.EventHandler(this.buttonToDownloadData_GTS_Click_1);
            // 
            // buttonInfo_GTS
            // 
            this.buttonInfo_GTS.BackColor = System.Drawing.Color.Tomato;
            this.buttonInfo_GTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonInfo_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.help;
            this.buttonInfo_GTS.Location = new System.Drawing.Point(805, 0);
            this.buttonInfo_GTS.Name = "buttonInfo_GTS";
            this.buttonInfo_GTS.Size = new System.Drawing.Size(63, 80);
            this.buttonInfo_GTS.TabIndex = 4;
            this.toolTip_GTS.SetToolTip(this.buttonInfo_GTS, "О программе");
            this.buttonInfo_GTS.UseVisualStyleBackColor = false;
            this.buttonInfo_GTS.Click += new System.EventHandler(this.buttonInfo_GTS_Click);
            // 
            // button_AddToData_GTS
            // 
            this.button_AddToData_GTS.BackColor = System.Drawing.Color.Coral;
            this.button_AddToData_GTS.Enabled = false;
            this.button_AddToData_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddToData_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.database_add;
            this.button_AddToData_GTS.Location = new System.Drawing.Point(136, 13);
            this.button_AddToData_GTS.Name = "button_AddToData_GTS";
            this.button_AddToData_GTS.Size = new System.Drawing.Size(118, 49);
            this.button_AddToData_GTS.TabIndex = 3;
            this.toolTip_GTS.SetToolTip(this.button_AddToData_GTS, "Добавить данные");
            this.button_AddToData_GTS.UseVisualStyleBackColor = false;
            this.button_AddToData_GTS.Click += new System.EventHandler(this.button_AddToData_GTS_Click_1);
            // 
            // buttonFAQ_GTS
            // 
            this.buttonFAQ_GTS.BackColor = System.Drawing.Color.Tomato;
            this.buttonFAQ_GTS.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFAQ_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFAQ_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.user;
            this.buttonFAQ_GTS.Location = new System.Drawing.Point(868, 0);
            this.buttonFAQ_GTS.Name = "buttonFAQ_GTS";
            this.buttonFAQ_GTS.Size = new System.Drawing.Size(63, 80);
            this.buttonFAQ_GTS.TabIndex = 2;
            this.toolTip_GTS.SetToolTip(this.buttonFAQ_GTS, "Об авторе");
            this.buttonFAQ_GTS.UseVisualStyleBackColor = false;
            this.buttonFAQ_GTS.Click += new System.EventHandler(this.buttonFAQ_GTS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 439);
            this.Controls.Add(this.panel_Grid_GTS);
            this.Controls.Add(this.panel_info_GTS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог фильмов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Grid_GTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClips_GTS)).EndInit();
            this.panel_info_GTS.ResumeLayout(false);
            this.groupBoxSearch_GTS.ResumeLayout(false);
            this.groupBoxSearch_GTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Grid_GTS;
        private System.Windows.Forms.DataGridView dataGridViewClips_GTS;
        private System.Windows.Forms.Panel panel_info_GTS;
        private System.Windows.Forms.GroupBox groupBoxSearch_GTS;
        private System.Windows.Forms.TextBox textBoxSearch_GTS;
        private System.Windows.Forms.Button buttonImportCSV_GTS;
        private System.Windows.Forms.Button buttonToDownloadData_GTS;
        private System.Windows.Forms.Button buttonInfo_GTS;
        private System.Windows.Forms.Button button_AddToData_GTS;
        private System.Windows.Forms.Button buttonFAQ_GTS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFilmData_GTS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GTS;
        private System.Windows.Forms.ToolTip toolTip_GTS;
        private System.Windows.Forms.Button button_Stat_GTS;
    }
}

