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
    public partial class Lr5Zd2 : Form
    {
        public Lr5Zd2()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Lr5Zd2_MouseClick(object sender, MouseEventArgs e)
        {
            int p = this.Width;
            if (e.Location.X < (p / 2) && e.Location.X > 0)
            {
                Button b = new Button()
                {
                    Location = e.Location,
                };
                this.Controls.Add(b);
                b.Text = e.Location.X + ";" + e.Location.Y;


            }
            else
            {
                TextBox b = new TextBox()
                {
                    Location = e.Location,
                };
                this.Controls.Add(b);
                b.Text = e.Location.X + ";" + e.Location.Y;


            }
        }

        private void Lr5Zd2_Load(object sender, EventArgs e)
        {

        }
    }
}

      
