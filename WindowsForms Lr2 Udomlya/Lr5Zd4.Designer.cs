namespace WindowsForms_Lr2_Udomlya
{
    partial class Lr5Zd4
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
            this.Zad4 = new System.Windows.Forms.Button();
            this.Nazad = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Zad4
            // 
            this.Zad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zad4.Location = new System.Drawing.Point(286, 23);
            this.Zad4.Name = "Zad4";
            this.Zad4.Size = new System.Drawing.Size(182, 42);
            this.Zad4.TabIndex = 25;
            this.Zad4.Text = "Задание № 4";
            this.Zad4.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(618, 371);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 148;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Panel1.Location = new System.Drawing.Point(160, 144);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(81, 214);
            this.Panel1.TabIndex = 152;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Panel2.Location = new System.Drawing.Point(330, 144);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(81, 214);
            this.Panel2.TabIndex = 153;
            this.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseClick);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Panel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Panel3.Location = new System.Drawing.Point(501, 144);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(81, 214);
            this.Panel3.TabIndex = 154;
            this.Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseClick);
            // 
            // Lr5Zd4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Zad4);
            this.Name = "Lr5Zd4";
            this.Text = "Лабораторная работа №5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zad4;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
    }
}