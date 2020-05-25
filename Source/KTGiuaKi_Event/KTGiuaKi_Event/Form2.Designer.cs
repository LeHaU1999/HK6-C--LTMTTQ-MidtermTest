namespace KTGiuaKi_Event
{
    partial class frmClickVsTimerTick
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnBg = new System.Windows.Forms.Panel();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.picStone = new System.Windows.Forms.PictureBox();
            this.picTrap = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.picMove6 = new System.Windows.Forms.PictureBox();
            this.picMove10 = new System.Windows.Forms.PictureBox();
            this.picMove1 = new System.Windows.Forms.PictureBox();
            this.picMove9 = new System.Windows.Forms.PictureBox();
            this.picMove2 = new System.Windows.Forms.PictureBox();
            this.picMove8 = new System.Windows.Forms.PictureBox();
            this.picMove3 = new System.Windows.Forms.PictureBox();
            this.picMove7 = new System.Windows.Forms.PictureBox();
            this.picMove4 = new System.Windows.Forms.PictureBox();
            this.picMove5 = new System.Windows.Forms.PictureBox();
            this.pnBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnBg
            // 
            this.pnBg.BackgroundImage = global::KTGiuaKi_Event.Properties.Resources.bg;
            this.pnBg.Controls.Add(this.picWater);
            this.pnBg.Controls.Add(this.picStone);
            this.pnBg.Controls.Add(this.picTrap);
            this.pnBg.Controls.Add(this.btnDown);
            this.pnBg.Controls.Add(this.btnUp);
            this.pnBg.Controls.Add(this.picMove6);
            this.pnBg.Controls.Add(this.picMove10);
            this.pnBg.Controls.Add(this.picMove1);
            this.pnBg.Controls.Add(this.picMove9);
            this.pnBg.Controls.Add(this.picMove2);
            this.pnBg.Controls.Add(this.picMove8);
            this.pnBg.Controls.Add(this.picMove3);
            this.pnBg.Controls.Add(this.picMove7);
            this.pnBg.Controls.Add(this.picMove4);
            this.pnBg.Controls.Add(this.picMove5);
            this.pnBg.Location = new System.Drawing.Point(3, 1);
            this.pnBg.Name = "pnBg";
            this.pnBg.Size = new System.Drawing.Size(958, 354);
            this.pnBg.TabIndex = 11;
            this.pnBg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnBg_MouseUp);
            // 
            // picWater
            // 
            this.picWater.BackColor = System.Drawing.Color.Transparent;
            this.picWater.Image = global::KTGiuaKi_Event.Properties.Resources.water_removebg_preview;
            this.picWater.Location = new System.Drawing.Point(691, 295);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(63, 56);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWater.TabIndex = 14;
            this.picWater.TabStop = false;
            // 
            // picStone
            // 
            this.picStone.BackColor = System.Drawing.Color.Transparent;
            this.picStone.Image = global::KTGiuaKi_Event.Properties.Resources.stone_removebg_preview;
            this.picStone.Location = new System.Drawing.Point(884, 195);
            this.picStone.Name = "picStone";
            this.picStone.Size = new System.Drawing.Size(63, 56);
            this.picStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStone.TabIndex = 13;
            this.picStone.TabStop = false;
            // 
            // picTrap
            // 
            this.picTrap.BackColor = System.Drawing.Color.Transparent;
            this.picTrap.Image = global::KTGiuaKi_Event.Properties.Resources.trap_removebg_preview;
            this.picTrap.Location = new System.Drawing.Point(562, 124);
            this.picTrap.Name = "picTrap";
            this.picTrap.Size = new System.Drawing.Size(63, 56);
            this.picTrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrap.TabIndex = 12;
            this.picTrap.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(90, 11);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(9, 11);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnNhay_Click);
            // 
            // picMove6
            // 
            this.picMove6.BackColor = System.Drawing.Color.Transparent;
            this.picMove6.Image = global::KTGiuaKi_Event.Properties.Resources.move6_removebg_preview;
            this.picMove6.Location = new System.Drawing.Point(355, 124);
            this.picMove6.Name = "picMove6";
            this.picMove6.Size = new System.Drawing.Size(99, 140);
            this.picMove6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove6.TabIndex = 5;
            this.picMove6.TabStop = false;
            this.picMove6.Visible = false;
            // 
            // picMove10
            // 
            this.picMove10.BackColor = System.Drawing.Color.Transparent;
            this.picMove10.Image = global::KTGiuaKi_Event.Properties.Resources.move10_removebg_preview;
            this.picMove10.Location = new System.Drawing.Point(355, 124);
            this.picMove10.Name = "picMove10";
            this.picMove10.Size = new System.Drawing.Size(99, 140);
            this.picMove10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove10.TabIndex = 9;
            this.picMove10.TabStop = false;
            this.picMove10.Visible = false;
            // 
            // picMove1
            // 
            this.picMove1.BackColor = System.Drawing.Color.Transparent;
            this.picMove1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMove1.Image = global::KTGiuaKi_Event.Properties.Resources.move1_removebg_preview;
            this.picMove1.Location = new System.Drawing.Point(355, 124);
            this.picMove1.Name = "picMove1";
            this.picMove1.Size = new System.Drawing.Size(99, 140);
            this.picMove1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove1.TabIndex = 0;
            this.picMove1.TabStop = false;
            // 
            // picMove9
            // 
            this.picMove9.BackColor = System.Drawing.Color.Transparent;
            this.picMove9.Image = global::KTGiuaKi_Event.Properties.Resources.move9_removebg_preview;
            this.picMove9.Location = new System.Drawing.Point(355, 124);
            this.picMove9.Name = "picMove9";
            this.picMove9.Size = new System.Drawing.Size(99, 140);
            this.picMove9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove9.TabIndex = 8;
            this.picMove9.TabStop = false;
            this.picMove9.Visible = false;
            // 
            // picMove2
            // 
            this.picMove2.BackColor = System.Drawing.Color.Transparent;
            this.picMove2.Image = global::KTGiuaKi_Event.Properties.Resources.move2_removebg_preview;
            this.picMove2.Location = new System.Drawing.Point(355, 124);
            this.picMove2.Name = "picMove2";
            this.picMove2.Size = new System.Drawing.Size(99, 140);
            this.picMove2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove2.TabIndex = 1;
            this.picMove2.TabStop = false;
            this.picMove2.Visible = false;
            // 
            // picMove8
            // 
            this.picMove8.BackColor = System.Drawing.Color.Transparent;
            this.picMove8.Image = global::KTGiuaKi_Event.Properties.Resources.move8_removebg_preview;
            this.picMove8.Location = new System.Drawing.Point(355, 124);
            this.picMove8.Name = "picMove8";
            this.picMove8.Size = new System.Drawing.Size(99, 140);
            this.picMove8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove8.TabIndex = 7;
            this.picMove8.TabStop = false;
            this.picMove8.Visible = false;
            // 
            // picMove3
            // 
            this.picMove3.BackColor = System.Drawing.Color.Transparent;
            this.picMove3.Image = global::KTGiuaKi_Event.Properties.Resources.move3_removebg_preview;
            this.picMove3.Location = new System.Drawing.Point(355, 124);
            this.picMove3.Name = "picMove3";
            this.picMove3.Size = new System.Drawing.Size(99, 140);
            this.picMove3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove3.TabIndex = 2;
            this.picMove3.TabStop = false;
            this.picMove3.Visible = false;
            // 
            // picMove7
            // 
            this.picMove7.BackColor = System.Drawing.Color.Transparent;
            this.picMove7.Image = global::KTGiuaKi_Event.Properties.Resources.move7_removebg_preview;
            this.picMove7.Location = new System.Drawing.Point(355, 124);
            this.picMove7.Name = "picMove7";
            this.picMove7.Size = new System.Drawing.Size(99, 140);
            this.picMove7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove7.TabIndex = 6;
            this.picMove7.TabStop = false;
            this.picMove7.Visible = false;
            // 
            // picMove4
            // 
            this.picMove4.BackColor = System.Drawing.Color.Transparent;
            this.picMove4.Image = global::KTGiuaKi_Event.Properties.Resources.move4_removebg_preview;
            this.picMove4.Location = new System.Drawing.Point(355, 124);
            this.picMove4.Name = "picMove4";
            this.picMove4.Size = new System.Drawing.Size(99, 140);
            this.picMove4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove4.TabIndex = 3;
            this.picMove4.TabStop = false;
            this.picMove4.Visible = false;
            // 
            // picMove5
            // 
            this.picMove5.BackColor = System.Drawing.Color.Transparent;
            this.picMove5.Image = global::KTGiuaKi_Event.Properties.Resources.move5_removebg_preview;
            this.picMove5.Location = new System.Drawing.Point(355, 124);
            this.picMove5.Name = "picMove5";
            this.picMove5.Size = new System.Drawing.Size(99, 140);
            this.picMove5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMove5.TabIndex = 4;
            this.picMove5.TabStop = false;
            this.picMove5.Visible = false;
            // 
            // frmClickVsTimerTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 358);
            this.Controls.Add(this.pnBg);
            this.Name = "frmClickVsTimerTick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Click And Time Tick";
            this.pnBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMove5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBg;
        private System.Windows.Forms.PictureBox picMove6;
        private System.Windows.Forms.PictureBox picMove10;
        private System.Windows.Forms.PictureBox picMove1;
        private System.Windows.Forms.PictureBox picMove9;
        private System.Windows.Forms.PictureBox picMove2;
        private System.Windows.Forms.PictureBox picMove8;
        private System.Windows.Forms.PictureBox picMove3;
        private System.Windows.Forms.PictureBox picMove7;
        private System.Windows.Forms.PictureBox picMove4;
        private System.Windows.Forms.PictureBox picMove5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.PictureBox picStone;
        private System.Windows.Forms.PictureBox picTrap;
    }
}