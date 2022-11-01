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
    public partial class Lr5Zd5 : Form
    {
        public Lr5Zd5()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Lr5Zd5_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 30;
            int y = 30;
            int r = 30;
            for (int i = 0; i < x*y; i++)
            {
                Button b = new Button();
                b.Location = new Point((i % x + 1) * r, (i / y + 1) * r);
                b.Size = new Size(30,30);
                this.Controls.Add(b);
            }    


        }
    }
}
