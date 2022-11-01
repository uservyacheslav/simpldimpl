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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
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

            double a =Math.Pow( Math.Abs((Math.Cos(x) - Math.Cos(y))),1 + 2 * Math.Pow(Math.Sin(y), 2));

            double b = 1 + z + (Math.Pow(z, 2) / 2 + Math.Pow(z, 3) / 3 + Math.Pow(z, 4) / 4);

            double w = a * b;

            Tb4.Text += Environment.NewLine + "Результат" + w.ToString();
        }
    }
}
