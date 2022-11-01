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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
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

            double a = 1 + Math.Pow(Math.Sin(x + y), 2);

            double b = Math.Abs(x - ((2 * y) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));

            double c = Math.Pow(x, Math.Abs(y));

            double f = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            double v = a / b * c + f;

            Tb4.Text += Environment.NewLine + "Результат" + v.ToString();




        }
    }
}
