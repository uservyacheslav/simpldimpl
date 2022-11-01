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
    public partial class Lr5Zd3 : Form
    {
        public Lr5Zd3()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button()
            {
                Location = e.Location,
            };
            Panel1.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;

        }

        private void Lr5Zd3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox b = new TextBox()
            {
                Location = Panel1.Location,
            };
            Panel1.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }
    }
}
