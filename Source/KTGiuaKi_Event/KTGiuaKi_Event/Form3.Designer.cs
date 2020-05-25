namespace KTGiuaKi_Event
{
    partial class Form3
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
            this.pnBg = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.picMove6 = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.pnBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMove6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBg
            // 
            this.pnBg.Controls.Add(this.btnDown);
            this.pnBg.Controls.Add(this.btnUp);
            this.pnBg.Controls.Add(this.picMove6);
            this.pnBg.Location = new System.Drawing.Point(4, -6);
            this.pnBg.Name = "pnBg";
            this.pnBg.Size = new System.Drawing.Size(978, 354);
            this.pnBg.TabIndex = 12;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(8, 18);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnNhay_Click);
            // 
            // picMove6
            // 
            this.picMove6.Image = global::KTGiuaKi_Event.Properties.Resources.move6_removebg_preview;
            this.picMove6.Location = new System.Drawing.Point(359, 110);
            this.picMove6.Name = "picMove6";
            this.picMove6.Size = new System.Drawing.Size(99, 140);
            this.picMove6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove6.TabIndex = 5;
            this.picMove6.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(89, 18);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 342);
            this.Controls.Add(this.pnBg);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Click";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form3_KeyPress);
            this.pnBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMove6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBg;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.PictureBox picMove6;
        private System.Windows.Forms.Button btnDown;
    }
}