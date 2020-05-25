using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoDelegate_CommunicatedBetwenTwoForm.DaoImpl;
using DemoDelegate_CommunicatedBetwenTwoForm.Idao;
using DemoDelegate_CommunicatedBetwenTwoForm.Modle;

namespace DemoDelegate_CommunicatedBetwenTwoForm.Views
{
    public partial class frmA : Form
    {
        IDaoFrmA idaoFrm = new FrmAImpl();

        //khai báo frmB
        frmB myFrmB = new frmB();

        //tạo một delegate truyền mesage từ frmA sang frmB
        public delegate void SendDataAToB(TextBox text);

        //delegate truyền id object cho frmB 
        public delegate void PassIdFormA(frmA _frmA);
        public frmA()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvFrmA.DataSource = idaoFrm.getAllMessageFrmA();
        }
        public void FunDataA(TextBox txtFormB)
        {
            rtxtA.Text = txtFormB.Text;
        }

        private void btnCreateForm_Click(object sender, EventArgs e)
        {
            myFrmB.Show();
            btnSendDataToB.Enabled = true;
        }

        private void frmA_Load(object sender, EventArgs e)
        {
            txtA.Focus();
            btnSendDataToB.Enabled = false;
            loadData();
        }

        private void btnSendDataToB_Click_1(object sender, EventArgs e)
        {
            //dùng delegate send message từ frmA sang frmB
            //khởi tạo mới một delegate sau đó truyền  hàm FunDataB từ formB sang 
            // truyền vào giá trị của txtA vào trong dataSend 
            //frmB sẽ nhận giá trị của txtA thông qua hàm FunDataB và hiển thị lên frmB
            SendDataAToB dataSend = new SendDataAToB(myFrmB.FunDataB);
            dataSend(this.txtA);

            //hàm save message vào db
            FormContent message = new FormContent();
            message.messageText = "A: "+ txtA.Text;
            idaoFrm.addMessage(message);
            loadData();
            myFrmB.loadData();


            PassIdFormA dataObject = new PassIdFormA(myFrmB.FunObjectB);
            dataObject(this);
        }
    }
}
