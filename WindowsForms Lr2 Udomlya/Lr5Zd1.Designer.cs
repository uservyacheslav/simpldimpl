namespace WindowsForms_Lr2_Udomlya
{
    partial class Lr5Zd1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lab5 = new System.Windows.Forms.Label();
            this.Zad1 = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(241, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кутепов Вячеслав Сергеевич";
            // 
            // Lab5
            // 
            this.Lab5.AutoSize = true;
            this.Lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lab5.Location = new System.Drawing.Point(256, 18);
            this.Lab5.Name = "Lab5";
            this.Lab5.Size = new System.Drawing.Size(256, 25);
            this.Lab5.TabIndex = 21;
            this.Lab5.Text = "Лабораторная работа № 5";
            // 
            // Zad1
            // 
            this.Zad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zad1.Location = new System.Drawing.Point(271, 97);
            this.Zad1.Name = "Zad1";
            this.Zad1.Size = new System.Drawing.Size(182, 42);
            this.Zad1.TabIndex = 22;
            this.Zad1.Text = "Задание № 1";
            this.Zad1.UseVisualStyleBackColor = true;
            this.Zad1.Click += new System.EventHandler(this.Zad1_Click);
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(613, 350);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 147;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Lr5Zd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Zad1);
            this.Controls.Add(this.Lab5);
            this.Controls.Add(this.label1);
            this.Name = "Lr5Zd1";
            this.Text = "Лабораторная работа № 5";
            this.Load += new System.EventHandler(this.Lr5Zd1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lr5Zd1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab5;
        private System.Windows.Forms.Button Zad1;
        private System.Windows.Forms.Button Nazad;
    }
}