using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateUserControl.Usercontrol
{
    public partial class UserControl_Number : UserControl
    {
        public UserControl_Number()
        {
            InitializeComponent();
        }

        public delegate void Numvalue();
        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
