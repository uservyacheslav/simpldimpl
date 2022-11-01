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
    public partial class Zd1 : Form
    {
        public Zd1()
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
            if ( stepenx.Checked)
            { 
                f = Math.Pow(x, 2);
            }
            if (stepene.Checked)
            {
                f = Math.Exp(x);
            }
            double a ;
            if (x*y>0)
            {
                a = Math.Pow((f + y), 2) - Math.Sqrt(f * y);
            }
            else if ( x*y<0)
            {
               a  = Math.Pow((f + y), 2) - Math.Sqrt(Math.Abs(f * y));
            }
            else
            {
                a = Math.Pow((f + y), 2) + 1;
            }
            Tb5.Text += "Результат a = " + a.ToString()+Environment.NewLine;



        }
    }
}

