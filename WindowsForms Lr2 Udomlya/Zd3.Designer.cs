namespace WindowsForms_Lr2_Udomlya
{
    partial class Zd3
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
            this.stepene = new System.Windows.Forms.RadioButton();
            this.stepenx = new System.Windows.Forms.RadioButton();
            this.sinus = new System.Windows.Forms.RadioButton();
            this.Nazad = new System.Windows.Forms.Button();
            this.Vupolnit = new System.Windows.Forms.Button();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.Tb5 = new System.Windows.Forms.TextBox();
            this.Prog = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stepene
            // 
            this.stepene.AutoSize = true;
            this.stepene.Location = new System.Drawing.Point(578, 113);
            this.stepene.Name = "stepene";
            this.stepene.Size = new System.Drawing.Size(49, 20);
            this.stepene.TabIndex = 66;
            this.stepene.TabStop = true;
            this.stepene.Text = "e^x";
            this.stepene.UseVisualStyleBackColor = true;
            // 
            // stepenx
            // 
            this.stepenx.AutoSize = true;
            this.stepenx.Location = new System.Drawing.Point(578, 70);
            this.stepenx.Name = "stepenx";
            this.stepenx.Size = new System.Drawing.Size(48, 20);
            this.stepenx.TabIndex = 65;
            this.stepenx.TabStop = true;
            this.stepenx.Text = "x^2";
            this.stepenx.UseVisualStyleBackColor = true;
            // 
            // sinus
            // 
            this.sinus.AutoSize = true;
            this.sinus.Location = new System.Drawing.Point(578, 33);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(56, 20);
            this.sinus.TabIndex = 64;
            this.sinus.TabStop = true;
            this.sinus.Text = "sh(x)";
            this.sinus.UseVisualStyleBackColor = true;
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nazad.Location = new System.Drawing.Point(706, 21);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(153, 55);
            this.Nazad.TabIndex = 63;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Vupolnit
            // 
            this.Vupolnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vupolnit.Location = new System.Drawing.Point(706, 124);
            this.Vupolnit.Name = "Vupolnit";
            this.Vupolnit.Size = new System.Drawing.Size(163, 39);
            this.Vupolnit.TabIndex = 62;
            this.Vupolnit.Text = "Выполнить";
            this.Vupolnit.UseVisualStyleBackColor = true;
            this.Vupolnit.Click += new System.EventHandler(this.Vupolnit_Click);
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(417, 109);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(100, 22);
            this.Tb2.TabIndex = 61;
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(417, 69);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(100, 22);
            this.Tb1.TabIndex = 60;
            // 
            // Tb5
            // 
            this.Tb5.Location = new System.Drawing.Point(107, 232);
            this.Tb5.Multiline = true;
            this.Tb5.Name = "Tb5";
            this.Tb5.Size = new System.Drawing.Size(441, 197);
            this.Tb5.TabIndex = 59;
            // 
            // Prog
            // 
            this.Prog.AutoSize = true;
            this.Prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prog.Location = new System.Drawing.Point(102, 171);
            this.Prog.Name = "Prog";
            this.Prog.Size = new System.Drawing.Size(374, 25);
            this.Prog.TabIndex = 58;
            this.Prog.Text = "Результат выполнения программы";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(102, 109);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(219, 25);
            this.Y.TabIndex = 57;
            this.Y.Text = "Введите значение Y";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(102, 65);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(220, 25);
            this.x.TabIndex = 56;
            this.x.Text = "Введите значение X";
            // 
            // Zd3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.stepene);
            this.Controls.Add(this.stepenx);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Vupolnit);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.Tb5);
            this.Controls.Add(this.Prog);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.x);
            this.Name = "Zd3";
            this.Text = "Задание № 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton stepene;
        private System.Windows.Forms.RadioButton stepenx;
        private System.Windows.Forms.RadioButton sinus;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Vupolnit;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.TextBox Tb5;
        private System.Windows.Forms.Label Prog;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label x;
    }
}