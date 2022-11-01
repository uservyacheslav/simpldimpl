namespace WindowsForms_Lr2_Udomlya
{
    partial class Lr5Zd2
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
            this.Zad2 = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zad2
            // 
            this.Zad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zad2.Location = new System.Drawing.Point(305, 12);
            this.Zad2.Name = "Zad2";
            this.Zad2.Size = new System.Drawing.Size(182, 42);
            this.Zad2.TabIndex = 26;
            this.Zad2.Text = "Задание № 2";
            this.Zad2.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(610, 355);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 148;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Lr5Zd2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Zad2);
            this.Name = "Lr5Zd2";
            this.Text = "Лабораторная работа № 5";
            this.Load += new System.EventHandler(this.Lr5Zd2_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lr5Zd2_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zad2;
        private System.Windows.Forms.Button Nazad;
    }
}