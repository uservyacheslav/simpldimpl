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
    public partial class Lr5Zd4 : Form
    {
        public Lr5Zd4()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button()
            {
                Location = e.Location,
            };
            Panel2.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;

        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox b = new TextBox()
            {
                Location = e.Location,
            };
            Panel3.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;

        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Label b = new Label()
            {
                Location = e.Location,
            };
            b.Text = "задание";
            Panel1.Controls.Add(b);
           

        }
    }
}
