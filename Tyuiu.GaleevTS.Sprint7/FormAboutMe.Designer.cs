
namespace Tyuiu.GaleevTS.Sprint7
{
    partial class FormAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe));
            this.groupBoxAboutMe_GTS = new System.Windows.Forms.GroupBox();
            this.button_Close_GTS = new System.Windows.Forms.Button();
            this.textBoxInfoAboutMe_GTS = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxAboutMe_GTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAboutMe_GTS
            // 
            this.groupBoxAboutMe_GTS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAboutMe_GTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAboutMe_GTS.Controls.Add(this.button_Close_GTS);
            this.groupBoxAboutMe_GTS.Controls.Add(this.textBoxInfoAboutMe_GTS);
            this.groupBoxAboutMe_GTS.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAboutMe_GTS.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAboutMe_GTS.Location = new System.Drawing.Point(302, 12);
            this.groupBoxAboutMe_GTS.Name = "groupBoxAboutMe_GTS";
            this.groupBoxAboutMe_GTS.Size = new System.Drawing.Size(340, 357);
            this.groupBoxAboutMe_GTS.TabIndex = 3;
            this.groupBoxAboutMe_GTS.TabStop = false;
            this.groupBoxAboutMe_GTS.Text = "Информация об авторе программы:";
            // 
            // button_Close_GTS
            // 
            this.button_Close_GTS.BackColor = System.Drawing.Color.LightCoral;
            this.button_Close_GTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close_GTS.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Close_GTS.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.accept;
            this.button_Close_GTS.Location = new System.Drawing.Point(6, 286);
            this.button_Close_GTS.Name = "button_Close_GTS";
            this.button_Close_GTS.Size = new System.Drawing.Size(328, 53);
            this.button_Close_GTS.TabIndex = 2;
            this.button_Close_GTS.UseVisualStyleBackColor = false;
            this.button_Close_GTS.Click += new System.EventHandler(this.button_Close_GTS_Click);
            // 
            // textBoxInfoAboutMe_GTS
            // 
            this.textBoxInfoAboutMe_GTS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBoxInfoAboutMe_GTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfoAboutMe_GTS.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfoAboutMe_GTS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxInfoAboutMe_GTS.Location = new System.Drawing.Point(6, 32);
            this.textBoxInfoAboutMe_GTS.Multiline = true;
            this.textBoxInfoAboutMe_GTS.Name = "textBoxInfoAboutMe_GTS";
            this.textBoxInfoAboutMe_GTS.ReadOnly = true;
            this.textBoxInfoAboutMe_GTS.Size = new System.Drawing.Size(328, 198);
            this.textBoxInfoAboutMe_GTS.TabIndex = 3;
            this.textBoxInfoAboutMe_GTS.Text = resources.GetString("textBoxInfoAboutMe_GTS.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources.AQACCjVFilY9tQfBWZnO63NB_Nn4FCReV4vHENhJeJ6zLqLBhoEJT2aAcVEWfIOu155FrW6vSR2F0doiZ_aV_CZAKpA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tyuiu.GaleevTS.Sprint7.Properties.Resources._1616988818_4_p_fon_dlya_prilozheniya_4;
            this.ClientSize = new System.Drawing.Size(654, 372);
            this.Controls.Add(this.groupBoxAboutMe_GTS);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Об авторе:";
            this.groupBoxAboutMe_GTS.ResumeLayout(false);
            this.groupBoxAboutMe_GTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAboutMe_GTS;
        private System.Windows.Forms.Button button_Close_GTS;
        private System.Windows.Forms.TextBox textBoxInfoAboutMe_GTS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}