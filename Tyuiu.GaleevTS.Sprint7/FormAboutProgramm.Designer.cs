
namespace Tyuiu.GaleevTS.Sprint7
{
    partial class FormAboutProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutProgramm));
            this.groupBoxInfoAboutProgramm_GTS = new System.Windows.Forms.GroupBox();
            this.textBoxAboutProgramm_GTS = new System.Windows.Forms.TextBox();
            this.buttonCloseInfo_GTS = new System.Windows.Forms.Button();
            this.groupBoxInfoAboutProgramm_GTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfoAboutProgramm_GTS
            // 
            this.groupBoxInfoAboutProgramm_GTS.BackgroundImage = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources._1616988818_4_p_fon_dlya_prilozheniya_4;
            this.groupBoxInfoAboutProgramm_GTS.Controls.Add(this.buttonCloseInfo_GTS);
            this.groupBoxInfoAboutProgramm_GTS.Controls.Add(this.textBoxAboutProgramm_GTS);
            this.groupBoxInfoAboutProgramm_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfoAboutProgramm_GTS.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInfoAboutProgramm_GTS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInfoAboutProgramm_GTS.Name = "groupBoxInfoAboutProgramm_GTS";
            this.groupBoxInfoAboutProgramm_GTS.Size = new System.Drawing.Size(800, 716);
            this.groupBoxInfoAboutProgramm_GTS.TabIndex = 1;
            this.groupBoxInfoAboutProgramm_GTS.TabStop = false;
            this.groupBoxInfoAboutProgramm_GTS.Text = "О программе:";
            // 
            // textBoxAboutProgramm_GTS
            // 
            this.textBoxAboutProgramm_GTS.BackColor = System.Drawing.Color.Azure;
            this.textBoxAboutProgramm_GTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAboutProgramm_GTS.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAboutProgramm_GTS.Location = new System.Drawing.Point(3, 25);
            this.textBoxAboutProgramm_GTS.Multiline = true;
            this.textBoxAboutProgramm_GTS.Name = "textBoxAboutProgramm_GTS";
            this.textBoxAboutProgramm_GTS.ReadOnly = true;
            this.textBoxAboutProgramm_GTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAboutProgramm_GTS.Size = new System.Drawing.Size(794, 688);
            this.textBoxAboutProgramm_GTS.TabIndex = 1;
            this.textBoxAboutProgramm_GTS.Text = resources.GetString("textBoxAboutProgramm_GTS.Text");
            // 
            // buttonCloseInfo_GTS
            // 
            this.buttonCloseInfo_GTS.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCloseInfo_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseInfo_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.accept;
            this.buttonCloseInfo_GTS.Location = new System.Drawing.Point(611, 646);
            this.buttonCloseInfo_GTS.Name = "buttonCloseInfo_GTS";
            this.buttonCloseInfo_GTS.Size = new System.Drawing.Size(157, 58);
            this.buttonCloseInfo_GTS.TabIndex = 2;
            this.buttonCloseInfo_GTS.UseVisualStyleBackColor = false;
            this.buttonCloseInfo_GTS.Click += new System.EventHandler(this.buttonCloseInfo_GTS_Click);
            // 
            // FormAboutProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.groupBoxInfoAboutProgramm_GTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Описание программы:";
            this.groupBoxInfoAboutProgramm_GTS.ResumeLayout(false);
            this.groupBoxInfoAboutProgramm_GTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfoAboutProgramm_GTS;
        private System.Windows.Forms.TextBox textBoxAboutProgramm_GTS;
        private System.Windows.Forms.Button buttonCloseInfo_GTS;
    }
}