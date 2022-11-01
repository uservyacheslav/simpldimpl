using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Lr2_Udomlya
{
    public partial class Zd2 : Form
    {
        public Zd2()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Vupolnit_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(Tb1.Text);

            double y = Convert.ToDouble(Tb2.Text);

            double f = 0;

            Tb5.Text = "Результат" + Environment.NewLine;

            Tb5.Text += "x=" + Tb1.Text + Environment.NewLine;

            Tb5.Text += "y=" + Tb2.Text + Environment.NewLine;

            if (sinus.Checked)

            {
                f = Math.Sinh(x);
            }
            if (stepenx.Checked)
            {
                f = Math.Pow(x, 2);
            }
            if (stepene.Checked)
            {
                f = Math.Exp(x);
            }
            double a =0;
            if (x / y > 0 && y != 0)
            {
                a = Math.Log(f) + Math.Pow((Math.Pow(f, 2) + y), 3);
            }
            else if (x / y < 0 && y != 0)
            {
                a = Math.Log(Math.Abs(f / y)) + Math.Pow((f + y), 3);
            }
            else if (x == 0)

            {
                a = Math.Pow((Math.Pow(f, 2) + y), 3);
            }
            else if (y == 0)
            {
                a = 0;
            }
            Tb5.Text += "Результат a = " + a.ToString() + Environment.NewLine;

        }
    }
}
