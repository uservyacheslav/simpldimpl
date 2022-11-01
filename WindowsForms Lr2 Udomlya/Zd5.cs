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
    public partial class Zd5 : Form
    {
        public Zd5()
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
            double E = 0;
            if (y % 2 == 1 && x>0)
            {
                E = y*Math.Sqrt(f);
            }
            else if (y % 2 == 0 && x <0 )
            {
                E = y/2*Math.Sqrt(Math.Abs(f));
            }
            else
            {
               E = Math.Sqrt(Math.Abs(y*f));
            }
            Tb5.Text += "Результат E = " + E.ToString() + Environment.NewLine;
        }
    }
}
