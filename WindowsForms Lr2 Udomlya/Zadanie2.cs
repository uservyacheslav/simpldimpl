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
    public partial class Zadanie2 : Form
    {
        public Zadanie2()
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
            double x = double.Parse(Tb1.Text);
            Tb4.Text += Environment.NewLine + "X =" + x.ToString();
            double y = double.Parse(Tb2.Text);
            Tb4.Text += Environment.NewLine + "y =" + y.ToString();
            double z = double.Parse(Tb3.Text);
            Tb4.Text += Environment.NewLine + "z =" + z.ToString();
            double a = Math.Pow((8 + Math.Pow((Math.Abs(x - y)), 2) + 1), 1 / 3);
            double b = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;
            double c = Math.Pow(Math.E, Math.Abs(x - y));
            double d = Math.Pow((Math.Pow(Math.Tan(z), 2) + 1), x);
            double u = a / b - c * d;
            Tb4.Text += Environment.NewLine + "Результат" + u.ToString();



        }
    }
}
