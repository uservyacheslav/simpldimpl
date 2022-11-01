namespace WindowsForms_Lr2_Udomlya
{
    partial class Zadanie2
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
            this.x = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Prog = new System.Windows.Forms.Label();
            this.Tb4 = new System.Windows.Forms.TextBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.Vupolnit = new System.Windows.Forms.Button();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(39, 29);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(220, 25);
            this.x.TabIndex = 2;
            this.x.Text = "Введите значение X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(45, 78);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(219, 25);
            this.Y.TabIndex = 3;
            this.Y.Text = "Введите значение Y";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z.Location = new System.Drawing.Point(45, 126);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(224, 25);
            this.Z.TabIndex = 4;
            this.Z.Text = "Введите значение Z ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(287, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Задание № 2";
            // 
            // Prog
            // 
            this.Prog.AutoSize = true;
            this.Prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prog.Location = new System.Drawing.Point(12, 184);
            this.Prog.Name = "Prog";
            this.Prog.Size = new System.Drawing.Size(374, 25);
            this.Prog.TabIndex = 10;
            this.Prog.Text = "Результат выполнения программы";
            // 
            // Tb4
            // 
            this.Tb4.Location = new System.Drawing.Point(12, 241);
            this.Tb4.Multiline = true;
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(441, 197);
            this.Tb4.TabIndex = 11;
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(575, 29);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 12;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Vupolnit
            // 
            this.Vupolnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vupolnit.Location = new System.Drawing.Point(565, 126);
            this.Vupolnit.Name = "Vupolnit";
            this.Vupolnit.Size = new System.Drawing.Size(163, 39);
            this.Vupolnit.TabIndex = 13;
            this.Vupolnit.Text = "Выполнить";
            this.Vupolnit.UseVisualStyleBackColor = true;
            this.Vupolnit.Click += new System.EventHandler(this.Vupolnit_Click);
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(329, 32);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(100, 22);
            this.Tb1.TabIndex = 14;
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(329, 82);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(100, 22);
            this.Tb2.TabIndex = 15;
            // 
            // Tb3
            // 
            this.Tb3.Location = new System.Drawing.Point(329, 138);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(100, 22);
            this.Tb3.TabIndex = 16;
            // 
            // Zadanie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tb3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.Vupolnit);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Tb4);
            this.Controls.Add(this.Prog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.x);
            this.Name = "Zadanie2";
            this.Text = "Задание № 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Prog;
        private System.Windows.Forms.TextBox Tb4;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Vupolnit;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.TextBox Tb3;
    }
}