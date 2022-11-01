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
    public partial class Lr4Zd1 : Form
    {
        public Lr4Zd1()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Vupolnit_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(Tb1.Text);
            double xk = Convert.ToDouble(Tb2.Text);
            double dx = Convert.ToDouble(Tb3.Text);
            double a = Convert.ToDouble(Tb4.Text);
            double b = Convert.ToDouble(Tb5.Text);
            double c = Convert.ToDouble(Tb6.Text);
            Tb.Text = "Результат" + Environment.NewLine;

            double x = x0;
            while (x<=(xk+dx/2))
            {
                double y = (Math.Pow(10, -2) * b * c / x) + Math.Cos(Math.Sqrt(Math.Pow(a, 3) * x));

                Tb.Text += "x= " + Convert.ToString(x) + "; y =" + Convert.ToString(y)+Environment.NewLine;

                x = x + dx;


            }


        }
    }
}
