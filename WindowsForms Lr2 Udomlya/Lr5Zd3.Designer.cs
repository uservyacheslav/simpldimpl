namespace WindowsForms_Lr2_Udomlya
{
    partial class Lr5Zd3
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
            this.Nazad = new System.Windows.Forms.Button();
            this.Zad3 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(618, 340);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 149;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Zad3
            // 
            this.Zad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zad3.Location = new System.Drawing.Point(301, 28);
            this.Zad3.Name = "Zad3";
            this.Zad3.Size = new System.Drawing.Size(182, 35);
            this.Zad3.TabIndex = 150;
            this.Zad3.Text = "Задание № 3";
            this.Zad3.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Panel1.Location = new System.Drawing.Point(80, 116);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(481, 163);
            this.Panel1.TabIndex = 151;
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // Lr5Zd3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Zad3);
            this.Controls.Add(this.Nazad);
            this.Name = "Lr5Zd3";
            this.Text = "Лабораторная работа № 5";
            
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lr5Zd3_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Zad3;
        private System.Windows.Forms.Panel Panel1;
    }
}