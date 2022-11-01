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
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void x_Click(object sender, EventArgs e)
        {

        }

        private void Vupolnit_Click(object sender, EventArgs e)
        {
            double x = double.Parse(Tb1.Text);
            Tb4.Text += Environment.NewLine + "X =" + x.ToString();
            double y = double.Parse(Tb2.Text);
            Tb4.Text += Environment.NewLine + "y =" + y.ToString();
            double z = double.Parse(Tb3.Text);
            Tb4.Text += Environment.NewLine + "z =" + z.ToString();
            double a = 2 * Math.Cos(x - Math.PI / 6);
            double b = 0.5 + Math.Pow(Math.Sin(y), 2);
            double c = 1 + (Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            double t = a / b * c;
            Tb4.Text += Environment.NewLine + "Результат" + t.ToString();

        }
    }
}
