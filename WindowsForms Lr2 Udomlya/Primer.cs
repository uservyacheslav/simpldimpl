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
    public partial class Primer : Form
    {
        public Primer()
        {
            InitializeComponent();
        }

        private void Prim_Click(object sender, EventArgs e)
        {


        }

        private void y_Click(object sender, EventArgs e)
        {

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Vupolnit_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Tb1.Text);
            Tb4.Text += Environment.NewLine + "X =" + x.ToString();
            double y = double.Parse(Tb2.Text);
            Tb4.Text += Environment.NewLine + "y =" + y.ToString();
            double z = double.Parse(Tb3.Text);
            Tb4.Text += Environment.NewLine + "z =" + z.ToString();
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x*x)+Math.Sin(z*z));
            double u = a - b * c;
            Tb4.Text += Environment.NewLine + "Результат U = " + u.ToString();



        }
    }
}
