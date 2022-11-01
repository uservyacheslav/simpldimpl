namespace WindowsForms_Lr2_Udomlya
{
    partial class Primer
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
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.Tb2 = new System.Windows.Forms.TextBox();
            this.Tb3 = new System.Windows.Forms.TextBox();
            this.Prog = new System.Windows.Forms.Label();
            this.Tb4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vupolnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nazad
            // 
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.Location = new System.Drawing.Point(625, 25);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(139, 47);
            this.Nazad.TabIndex = 1;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = true;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x.Location = new System.Drawing.Point(55, 68);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(222, 25);
            this.x.TabIndex = 2;
            this.x.Text = "Введите значение z ";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y.Location = new System.Drawing.Point(55, 109);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(216, 25);
            this.y.TabIndex = 3;
            this.y.Text = "Введите значение y\r\n";
            this.y.Click += new System.EventHandler(this.y_Click);
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z.Location = new System.Drawing.Point(55, 157);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(216, 25);
            this.z.TabIndex = 4;
            this.z.Text = "Введите значение x";
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(382, 68);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(100, 22);
            this.Tb1.TabIndex = 5;
            // 
            // Tb2
            // 
            this.Tb2.Location = new System.Drawing.Point(382, 112);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(100, 22);
            this.Tb2.TabIndex = 6;
            // 
            // Tb3
            // 
            this.Tb3.Location = new System.Drawing.Point(382, 161);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(100, 22);
            this.Tb3.TabIndex = 7;
            // 
            // Prog
            // 
            this.Prog.AutoSize = true;
            this.Prog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prog.Location = new System.Drawing.Point(55, 198);
            this.Prog.Name = "Prog";
            this.Prog.Size = new System.Drawing.Size(374, 25);
            this.Prog.TabIndex = 8;
            this.Prog.Text = "Результат выполнения программы";
            // 
            // Tb4
            // 
            this.Tb4.Location = new System.Drawing.Point(25, 226);
            this.Tb4.Multiline = true;
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(441, 197);
            this.Tb4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Vupolnit
            // 
            this.Vupolnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vupolnit.Location = new System.Drawing.Point(625, 110);
            this.Vupolnit.Name = "Vupolnit";
            this.Vupolnit.Size = new System.Drawing.Size(163, 39);
            this.Vupolnit.TabIndex = 11;
            this.Vupolnit.Text = "Выполнить";
            this.Vupolnit.UseVisualStyleBackColor = true;
            this.Vupolnit.Click += new System.EventHandler(this.Vupolnit_Click);
            // 
            // Primer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vupolnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb4);
            this.Controls.Add(this.Prog);
            this.Controls.Add(this.Tb3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Nazad);
            this.Name = "Primer";
            this.Text = "Primer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.TextBox Tb1;
        private System.Windows.Forms.TextBox Tb2;
        private System.Windows.Forms.TextBox Tb3;
        private System.Windows.Forms.Label Prog;
        private System.Windows.Forms.TextBox Tb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Vupolnit;
    }
}