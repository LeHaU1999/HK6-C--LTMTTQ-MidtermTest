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
    public partial class frmClickVsTimerTick : Form
    {
        decimal go = 0;
        int speed = 8;
        Random rand = new Random();
        public frmClickVsTimerTick()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (go == 0)
            {
                timer1.Interval = 100;
                go = 1;
                picMove1.Visible = false;
                picMove2.Visible = true;
            }
            else if (go == 1)
            {
                timer1.Interval = 100;
                go = 2;
                picMove2.Visible = false;
                picMove3.Visible = true;
            }
            else if (go == 2)
            {
                timer1.Interval = 100;
                go = 3;
                picMove3.Visible = false;
                picMove4.Visible = true;
            }
            if (go == 3)
            {
                timer1.Interval = 100;
                go = 4;
                picMove4.Visible = false;
                picMove5.Visible = true;
            }
            else if (go == 4)
            {
                timer1.Interval = 100;
                go = 5;
                picMove5.Visible = false;
                picMove6.Visible = true;
            }
            else if (go == 5)
            {
                timer1.Interval = 100;
                go = 6;
                picMove6.Visible = false;
                picMove7.Visible = true;
            }
            if (go == 6)
            {
                timer1.Interval = 100;
                go = 7;
                picMove7.Visible = false;
                picMove8.Visible = true;
            }
            else if (go == 7)
            {
                timer1.Interval = 100;
                go = 8;
                picMove8.Visible = false;
                picMove9.Visible = true;
            }
            else if (go == 8)
            {
                timer1.Interval = 100;
                go = 9;
                picMove9.Visible = false;
                picMove10.Visible = true;
            }
            else if (go == 9)
            {
                timer1.Interval = 100;
                go = 0;
                picMove10.Visible = false;
                picMove1.Visible = true;
            }
            picTrap.Left -= speed;
            picWater.Left -= speed;
            picStone.Left -= speed;
            if(picTrap.Left < -150)
            {
                picTrap.Left = 970;
            }
            if (picStone.Left < -150)
            {
                picStone.Left = 970;
            }
            if (picWater.Left < -150)
            {
                picWater.Left = 970;
            }
            if(picTrap.Left < -150)
            {
                picMove1.Bounds.IntersectsWith(picStone.Bounds);
                picMove2.Bounds.IntersectsWith(picStone.Bounds);
                picMove3.Bounds.IntersectsWith(picStone.Bounds);
                picMove4.Bounds.IntersectsWith(picStone.Bounds);
                picMove5.Bounds.IntersectsWith(picStone.Bounds);
                picMove6.Bounds.IntersectsWith(picStone.Bounds);
                picMove7.Bounds.IntersectsWith(picStone.Bounds);
                picMove8.Bounds.IntersectsWith(picStone.Bounds);
                picMove9.Bounds.IntersectsWith(picStone.Bounds);
                picMove10.Bounds.IntersectsWith(picStone.Bounds);
                timer1.Stop();
            }
        }

        private void btnNhay_Click(object sender, EventArgs e)
        {
           
            picMove1.Top -= 100;
            picMove2.Top -= 100;
            picMove3.Top -= 100;
            picMove4.Top -= 100;
            picMove5.Top -= 100;
            picMove6.Top -= 100;
            picMove7.Top -= 100;
            picMove8.Top -= 100;
            picMove9.Top -= 100;
            picMove10.Top -= 100;
        }

        private void pnBg_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            picMove1.Top += 100;
            picMove2.Top += 100;
            picMove3.Top += 100;
            picMove4.Top += 100;
            picMove5.Top += 100;
            picMove6.Top += 100;
            picMove7.Top += 100;
            picMove8.Top += 100;
            picMove9.Top += 100;
            picMove10.Top += 100;
        }
    }
}
