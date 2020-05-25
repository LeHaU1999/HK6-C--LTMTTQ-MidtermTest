using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegateUser.DaoImpl;
using DelegateUser.IDao;
using DelegateUser.Model;
using DelegateUser.View;

namespace DelegateUser.View
{
    public partial class frmAddUser : Form
    {
 
        IUser idaoUser = new UserImpl();
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            User user = new User();
            user.Name = txtName.Text.Trim();
            user.SDT = txtSDT.Text.Trim();
            user.NamSinh = txtNamSinh.Text.Trim();
            user.DiaChi = rtxtdiaChi.Text.Trim();

            idaoUser.AddUser(user);
            MessageBox.Show("da them thanh cong", "thong bao");
            this.Hide();

        }
    }
}
