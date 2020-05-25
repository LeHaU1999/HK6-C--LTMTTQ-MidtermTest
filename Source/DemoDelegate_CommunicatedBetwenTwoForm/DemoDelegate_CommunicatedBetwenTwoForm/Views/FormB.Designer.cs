namespace DemoDelegate_CommunicatedBetwenTwoForm.Views
{
    partial class frmB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.rtxtB = new System.Windows.Forms.RichTextBox();
            this.pnB = new System.Windows.Forms.Panel();
            this.dgvFrmB = new System.Windows.Forms.DataGridView();
            this.btnSendDataToA = new System.Windows.Forms.Button();
            this.formABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrmB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formContentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(205, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 70);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(31, 383);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(360, 22);
            this.txtB.TabIndex = 2;
            // 
            // rtxtB
            // 
            this.rtxtB.Location = new System.Drawing.Point(31, 257);
            this.rtxtB.Name = "rtxtB";
            this.rtxtB.ReadOnly = true;
            this.rtxtB.Size = new System.Drawing.Size(360, 96);
            this.rtxtB.TabIndex = 1;
            this.rtxtB.Text = "";
            // 
            // pnB
            // 
            this.pnB.Controls.Add(this.dgvFrmB);
            this.pnB.Controls.Add(this.btnClose);
            this.pnB.Controls.Add(this.btnSendDataToA);
            this.pnB.Controls.Add(this.txtB);
            this.pnB.Controls.Add(this.rtxtB);
            this.pnB.Location = new System.Drawing.Point(12, 12);
            this.pnB.Name = "pnB";
            this.pnB.Size = new System.Drawing.Size(463, 517);
            this.pnB.TabIndex = 1;
            // 
            // dgvFrmB
            // 
            this.dgvFrmB.AllowUserToAddRows = false;
            this.dgvFrmB.AllowUserToDeleteRows = false;
            this.dgvFrmB.AutoGenerateColumns = false;
            this.dgvFrmB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrmB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.messageTextDataGridViewTextBoxColumn});
            this.dgvFrmB.DataSource = this.formABindingSource;
            this.dgvFrmB.Location = new System.Drawing.Point(31, 3);
            this.dgvFrmB.Name = "dgvFrmB";
            this.dgvFrmB.ReadOnly = true;
            this.dgvFrmB.RowHeadersWidth = 51;
            this.dgvFrmB.RowTemplate.Height = 24;
            this.dgvFrmB.Size = new System.Drawing.Size(360, 248);
            this.dgvFrmB.TabIndex = 6;
            // 
            // btnSendDataToA
            // 
            this.btnSendDataToA.Location = new System.Drawing.Point(33, 423);
            this.btnSendDataToA.Name = "btnSendDataToA";
            this.btnSendDataToA.Size = new System.Drawing.Size(166, 70);
            this.btnSendDataToA.TabIndex = 3;
            this.btnSendDataToA.Text = "Send Data";
            this.btnSendDataToA.UseVisualStyleBackColor = true;
            this.btnSendDataToA.Click += new System.EventHandler(this.btnSendDataToA_Click);
            // 
            // formABindingSource
            // 
            this.formABindingSource.DataSource = typeof(DemoDelegate_CommunicatedBetwenTwoForm.Modle.FormContent);
            // 
            // formContentBindingSource
            // 
            this.formContentBindingSource.DataSource = typeof(DemoDelegate_CommunicatedBetwenTwoForm.Modle.FormContent);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTTDataGridViewTextBoxColumn.Width = 40;
            // 
            // messageTextDataGridViewTextBoxColumn
            // 
            this.messageTextDataGridViewTextBoxColumn.DataPropertyName = "messageText";
            this.messageTextDataGridViewTextBoxColumn.HeaderText = "messageText";
            this.messageTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messageTextDataGridViewTextBoxColumn.Name = "messageTextDataGridViewTextBoxColumn";
            this.messageTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageTextDataGridViewTextBoxColumn.Width = 250;
            // 
            // frmB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 541);
            this.Controls.Add(this.pnB);
            this.Name = "frmB";
            this.Text = "FormB";
            this.pnB.ResumeLayout(false);
            this.pnB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrmB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formContentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RichTextBox rtxtB;
        private System.Windows.Forms.Panel pnB;
        private System.Windows.Forms.Button btnSendDataToA;
        private System.Windows.Forms.DataGridView dgvFrmB;
        private System.Windows.Forms.DataGridViewTextBoxColumn textFormADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource formABindingSource;
        private System.Windows.Forms.BindingSource formContentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTextDataGridViewTextBoxColumn;
    }
}