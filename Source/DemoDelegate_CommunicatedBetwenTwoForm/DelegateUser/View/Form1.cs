using DelegateUser.DaoImpl;
using DelegateUser.IDao;
using DelegateUser.Model;
using DelegateUser.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateUser
{
    public partial class frmDanhSachUser : Form
    {
        IUser idaoUser = new UserImpl();
       
        public frmDanhSachUser()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dgvDSUser.DataSource = idaoUser.getAllUser();
        }
       

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            frmAddUser _frmAddUser = new frmAddUser();
            _frmAddUser.ShowDialog();
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDanhSachUser_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
