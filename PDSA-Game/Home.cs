using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSA_Game
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Games.Game02 frm = new Games.Game02();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games.Game01 frm = new Games.Game01();
            frm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Games.Game03 frm = new Games.Game03();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Games.Game04 frm = new Games.Game04();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Games.Game05 frm = new Games.Game05();
            frm.Show();
        }
    }
}
