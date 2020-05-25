using DemoDelegate_CommunicatedBetwenTwoForm.DaoImpl;
using DemoDelegate_CommunicatedBetwenTwoForm.Idao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoDelegate_CommunicatedBetwenTwoForm.Modle;

namespace DemoDelegate_CommunicatedBetwenTwoForm.Views
{
    public partial class frmB : Form
    {
        IDaoFrmA idaoFrm = new FrmAImpl();
        public frmA myFormA;

        //tạo một delegate để chuyền message từ frmB cho frmA
        public delegate void SendDataBToA(TextBox text);
        public frmB()
        {
            InitializeComponent();
            loadData();
            txtB.Focus();
        }
        public void loadData()
        {
            dgvFrmB.DataSource = idaoFrm.getAllMessageFrmA();
        }
        public void FunDataB(TextBox txtFormA)
        {
            rtxtB.Text = txtFormA.Text;
        }

        public void FunObjectB(frmA _frmA)
        {
            this.myFormA = _frmA;
        }

        private void btnSendDataToA_Click(object sender, EventArgs e)
        {
            SendDataBToA dataSendBA = new SendDataBToA(myFormA.FunDataA);
            dataSendBA(this.txtB);

            //save message db
            FormContent message = new FormContent();
            message.messageText = "B: " + txtB.Text;
            idaoFrm.addMessage(message);
            loadData();
            myFormA.loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
