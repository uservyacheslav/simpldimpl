namespace WindowsForms_Lr2_Udomlya
{
    partial class Lr5Zd5
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
            this.Zad5 = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zad5
            // 
            this.Zad5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zad5.Location = new System.Drawing.Point(266, 25);
            this.Zad5.Name = "Zad5";
            this.Zad5.Size = new System.Drawing.Size(182, 42);
            this.Zad5.TabIndex = 26;
            this.Zad5.Text = "Задание № 5";
            this.Zad5.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(608, 330);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 150;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Lr5Zd5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Zad5);
            this.Name = "Lr5Zd5";
            this.Text = "Лабораторная работа №5";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lr5Zd5_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zad5;
        private System.Windows.Forms.Button Nazad;
    }
}