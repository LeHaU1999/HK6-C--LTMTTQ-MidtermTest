using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTGiuaKi_Event
{
    public partial class frmMouseEnterVsMouseLeave : Form
    {
        decimal go = 0;
        public frmMouseEnterVsMouseLeave()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            picMove1.Visible = false;
            picMove2.Visible = true;
            pnBg.BackColor = Color.Green;
        }

        private void picMove2_MouseEnter(object sender, EventArgs e)
        {
            picMove2.Visible = false;
            picMove3.Visible = true;
            pnBg.BackColor = Color.Yellow;
        }
        private void picMove3_MouseEnter_1(object sender, EventArgs e)
        {
            picMove3.Visible = false;
            picMove4.Visible = true;
            pnBg.BackColor = Color.Red;
        }

        private void picMove4_MouseEnter(object sender, EventArgs e)
        {
            picMove4.Visible = false;
            picMove5.Visible = true;
            pnBg.BackColor = Color.Blue;
        }

        private void picMove5_MouseEnter(object sender, EventArgs e)
        {
            picMove5.Visible = false;
            picMove6.Visible = true;
            pnBg.BackColor = Color.Pink;
        }

        private void picMove6_MouseEnter(object sender, EventArgs e)
        {
            picMove6.Visible = false;
            picMove7.Visible = true;
            pnBg.BackColor = Color.Purple;
        }

        private void picMove7_MouseEnter(object sender, EventArgs e)
        {
            picMove7.Visible = false;
            picMove8.Visible = true;
            pnBg.BackColor = Color.YellowGreen;
        }

        private void picMove8_MouseEnter(object sender, EventArgs e)
        {
            picMove8.Visible = false;
            picMove9.Visible = true;
            pnBg.BackColor = Color.LightSteelBlue;
        }

        private void picMove9_MouseEnter(object sender, EventArgs e)
        {
            picMove9.Visible = false;
            picMove10.Visible = true;
            pnBg.BackColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void picMove10_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void picMove1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picMove2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void picMove10_MouseLeave(object sender, EventArgs e)
        {
            picMove10.Visible = false;
            picMove1.Visible = true;
            pnBg.BackColor = Color.White;
        }
    }
}
