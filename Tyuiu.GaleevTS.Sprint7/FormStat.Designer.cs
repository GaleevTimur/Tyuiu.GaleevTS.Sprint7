
namespace Tyuiu.GaleevTS.Sprint7
{
    partial class FormStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStat));
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.buttonCloseStat_GTS = new System.Windows.Forms.Button();
            this.labelSumOfLength = new System.Windows.Forms.Label();
            this.labelSumOfCost = new System.Windows.Forms.Label();
            this.textBoxStatOfLength_GTS = new System.Windows.Forms.TextBox();
            this.textBoxStatOfSum_GTS = new System.Windows.Forms.TextBox();
            this.groupBoxStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.BackgroundImage = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources._1616988818_4_p_fon_dlya_prilozheniya_4;
            this.groupBoxStat.Controls.Add(this.buttonCloseStat_GTS);
            this.groupBoxStat.Controls.Add(this.labelSumOfLength);
            this.groupBoxStat.Controls.Add(this.labelSumOfCost);
            this.groupBoxStat.Controls.Add(this.textBoxStatOfLength_GTS);
            this.groupBoxStat.Controls.Add(this.textBoxStatOfSum_GTS);
            this.groupBoxStat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStat.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Size = new System.Drawing.Size(776, 164);
            this.groupBoxStat.TabIndex = 2;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "Статистика:";
            // 
            // buttonCloseStat_GTS
            // 
            this.buttonCloseStat_GTS.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCloseStat_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseStat_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.accept;
            this.buttonCloseStat_GTS.Location = new System.Drawing.Point(0, 125);
            this.buttonCloseStat_GTS.Name = "buttonCloseStat_GTS";
            this.buttonCloseStat_GTS.Size = new System.Drawing.Size(776, 39);
            this.buttonCloseStat_GTS.TabIndex = 5;
            this.buttonCloseStat_GTS.UseVisualStyleBackColor = false;
            this.buttonCloseStat_GTS.Click += new System.EventHandler(this.buttonCloseStat_GTS_Click);
            // 
            // labelSumOfLength
            // 
            this.labelSumOfLength.AutoSize = true;
            this.labelSumOfLength.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumOfLength.Location = new System.Drawing.Point(461, 37);
            this.labelSumOfLength.Name = "labelSumOfLength";
            this.labelSumOfLength.Size = new System.Drawing.Size(179, 19);
            this.labelSumOfLength.TabIndex = 3;
            this.labelSumOfLength.Text = "Сумма длительности:";
            // 
            // labelSumOfCost
            // 
            this.labelSumOfCost.AutoSize = true;
            this.labelSumOfCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSumOfCost.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumOfCost.Location = new System.Drawing.Point(6, 40);
            this.labelSumOfCost.Name = "labelSumOfCost";
            this.labelSumOfCost.Size = new System.Drawing.Size(151, 19);
            this.labelSumOfCost.TabIndex = 2;
            this.labelSumOfCost.Text = "Сумма стоимости:";
            // 
            // textBoxStatOfLength_GTS
            // 
            this.textBoxStatOfLength_GTS.Location = new System.Drawing.Point(465, 62);
            this.textBoxStatOfLength_GTS.Name = "textBoxStatOfLength_GTS";
            this.textBoxStatOfLength_GTS.ReadOnly = true;
            this.textBoxStatOfLength_GTS.Size = new System.Drawing.Size(257, 29);
            this.textBoxStatOfLength_GTS.TabIndex = 1;
            // 
            // textBoxStatOfSum_GTS
            // 
            this.textBoxStatOfSum_GTS.Location = new System.Drawing.Point(6, 62);
            this.textBoxStatOfSum_GTS.Name = "textBoxStatOfSum_GTS";
            this.textBoxStatOfSum_GTS.ReadOnly = true;
            this.textBoxStatOfSum_GTS.Size = new System.Drawing.Size(257, 29);
            this.textBoxStatOfSum_GTS.TabIndex = 0;
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources._1616988818_4_p_fon_dlya_prilozheniya_4;
            this.ClientSize = new System.Drawing.Size(800, 188);
            this.Controls.Add(this.groupBoxStat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStat;
        private System.Windows.Forms.Button buttonCloseStat_GTS;
        private System.Windows.Forms.Label labelSumOfLength;
        private System.Windows.Forms.Label labelSumOfCost;
        private System.Windows.Forms.TextBox textBoxStatOfLength_GTS;
        private System.Windows.Forms.TextBox textBoxStatOfSum_GTS;
    }
}