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
    public partial class Lr5Zd1 : Form
    {
        public Lr5Zd1()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Lr5Zd1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button()
            {
                Location = e.Location,
            };
            this.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;

        }

        private void Zad1_Click(object sender, EventArgs e)
        {

        }

        private void Lr5Zd1_Load(object sender, EventArgs e)
        {

        }
    }
}

   


    

