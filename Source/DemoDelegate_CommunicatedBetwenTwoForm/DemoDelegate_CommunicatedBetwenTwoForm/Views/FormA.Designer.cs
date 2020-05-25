namespace DemoDelegate_CommunicatedBetwenTwoForm.Views
{
    partial class frmA
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
            this.pnA = new System.Windows.Forms.Panel();
            this.dgvFrmA = new System.Windows.Forms.DataGridView();
            this.btnSendDataToB = new System.Windows.Forms.Button();
            this.btnCreateForm = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.rtxtA = new System.Windows.Forms.RichTextBox();
            this.formContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrmA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnA
            // 
            this.pnA.Controls.Add(this.dgvFrmA);
            this.pnA.Controls.Add(this.btnSendDataToB);
            this.pnA.Controls.Add(this.btnCreateForm);
            this.pnA.Controls.Add(this.txtA);
            this.pnA.Controls.Add(this.rtxtA);
            this.pnA.Location = new System.Drawing.Point(13, 13);
            this.pnA.Name = "pnA";
            this.pnA.Size = new System.Drawing.Size(463, 512);
            this.pnA.TabIndex = 0;
            // 
            // dgvFrmA
            // 
            this.dgvFrmA.AllowUserToAddRows = false;
            this.dgvFrmA.AllowUserToDeleteRows = false;
            this.dgvFrmA.AutoGenerateColumns = false;
            this.dgvFrmA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrmA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.messageTextDataGridViewTextBoxColumn});
            this.dgvFrmA.DataSource = this.formContentBindingSource;
            this.dgvFrmA.Location = new System.Drawing.Point(35, 4);
            this.dgvFrmA.Name = "dgvFrmA";
            this.dgvFrmA.ReadOnly = true;
            this.dgvFrmA.RowHeadersWidth = 51;
            this.dgvFrmA.RowTemplate.Height = 24;
            this.dgvFrmA.Size = new System.Drawing.Size(360, 248);
            this.dgvFrmA.TabIndex = 5;
            // 
            // btnSendDataToB
            // 
            this.btnSendDataToB.Location = new System.Drawing.Point(209, 415);
            this.btnSendDataToB.Name = "btnSendDataToB";
            this.btnSendDataToB.Size = new System.Drawing.Size(186, 70);
            this.btnSendDataToB.TabIndex = 4;
            this.btnSendDataToB.Text = "Send Data";
            this.btnSendDataToB.UseVisualStyleBackColor = true;
            this.btnSendDataToB.Click += new System.EventHandler(this.btnSendDataToB_Click_1);
            // 
            // btnCreateForm
            // 
            this.btnCreateForm.Location = new System.Drawing.Point(37, 415);
            this.btnCreateForm.Name = "btnCreateForm";
            this.btnCreateForm.Size = new System.Drawing.Size(166, 70);
            this.btnCreateForm.TabIndex = 3;
            this.btnCreateForm.Text = "Create ";
            this.btnCreateForm.UseVisualStyleBackColor = true;
            this.btnCreateForm.Click += new System.EventHandler(this.btnCreateForm_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(35, 375);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(360, 22);
            this.txtA.TabIndex = 2;
            // 
            // rtxtA
            // 
            this.rtxtA.Location = new System.Drawing.Point(35, 258);
            this.rtxtA.Name = "rtxtA";
            this.rtxtA.ReadOnly = true;
            this.rtxtA.Size = new System.Drawing.Size(360, 96);
            this.rtxtA.TabIndex = 1;
            this.rtxtA.Text = "";
            // 
            // formContentBindingSource
            // 
            this.formContentBindingSource.DataSource = typeof(DemoDelegate_CommunicatedBetwenTwoForm.Modle.FormContent);
            // 
            // formABindingSource
            // 
            this.formABindingSource.DataSource = typeof(DemoDelegate_CommunicatedBetwenTwoForm.Modle.FormContent);
            // 
            // formBBindingSource
            // 
            this.formBBindingSource.DataSource = typeof(DemoDelegate_CommunicatedBetwenTwoForm.Modle.FormContent);
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
            // frmA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 537);
            this.Controls.Add(this.pnA);
            this.Name = "frmA";
            this.Text = "FormA";
            this.Load += new System.EventHandler(this.frmA_Load);
            this.pnA.ResumeLayout(false);
            this.pnA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrmA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnA;
        private System.Windows.Forms.Button btnSendDataToB;
        private System.Windows.Forms.Button btnCreateForm;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RichTextBox rtxtA;
        private System.Windows.Forms.DataGridViewTextBoxColumn textFormADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource formABindingSource;
        private System.Windows.Forms.BindingSource formBBindingSource;
        private System.Windows.Forms.DataGridView dgvFrmA;
        private System.Windows.Forms.BindingSource formContentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesageTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTextDataGridViewTextBoxColumn;
    }
}