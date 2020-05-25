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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("ok");
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Up)
            {
                MessageBox.Show("ok");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                MessageBox.Show("ok");
            }
        }

        private void btnNhay_Click(object sender, EventArgs e)
        {
            picMove6.Top -= 100;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            picMove6.Top += 100;
        }
    }
}
