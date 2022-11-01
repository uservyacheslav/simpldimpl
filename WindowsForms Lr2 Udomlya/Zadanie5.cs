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
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
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
            Tb5.Text += Environment.NewLine + "X =" + x.ToString();

            double y = double.Parse(Tb2.Text);
            Tb5.Text += Environment.NewLine + "y =" + y.ToString();

            double z = double.Parse(Tb3.Text);
            Tb5.Text += Environment.NewLine + "z =" + z.ToString();

            double a = Math.Log(Math.Pow(y,-Math.Sqrt(Math.Abs(x))));

            double b = x - y / 2;

            double c = Math.Pow(Math.Sin(Math.Atan(z)),2);
            
            double u = a * b + c;

            Tb5.Text += Environment.NewLine + "Результат" + u.ToString();

        }
    }
}

