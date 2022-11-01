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
    public partial class Lr4Zd4 : Form
    {
        public Lr4Zd4()
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
            double x0 = Convert.ToDouble(Tb1.Text);
            double xk = Convert.ToDouble(Tb2.Text);
            double dx = Convert.ToDouble(Tb3.Text);
            double a = Convert.ToDouble(Tb4.Text);
            double b = Convert.ToDouble(Tb5.Text);

            Tb.Text = "Результат" + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b),2);    

                Tb.Text += "x= " + Convert.ToString(x) + "; y =" + Convert.ToString(y) + Environment.NewLine;

                x = x + dx;

            }
        }
    }
}
        
