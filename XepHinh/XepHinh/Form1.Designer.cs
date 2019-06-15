namespace XepHinh
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_LoadImage = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.tm_ThoiGian = new System.Windows.Forms.Timer(this.components);
            this.pnl_HinhCat = new System.Windows.Forms.Panel();
            this.ptb_P13 = new System.Windows.Forms.PictureBox();
            this.ptb_P03 = new System.Windows.Forms.PictureBox();
            this.ptb_P06 = new System.Windows.Forms.PictureBox();
            this.ptb_P09 = new System.Windows.Forms.PictureBox();
            this.ptb_P12 = new System.Windows.Forms.PictureBox();
            this.ptb_P02 = new System.Windows.Forms.PictureBox();
            this.ptb_P05 = new System.Windows.Forms.PictureBox();
            this.ptb_P08 = new System.Windows.Forms.PictureBox();
            this.ptb_P11 = new System.Windows.Forms.PictureBox();
            this.ptb_P01 = new System.Windows.Forms.PictureBox();
            this.ptb_P04 = new System.Windows.Forms.PictureBox();
            this.ptb_P07 = new System.Windows.Forms.PictureBox();
            this.ptb_P10 = new System.Windows.Forms.PictureBox();
            this.pnl_HinhChinh = new System.Windows.Forms.Panel();
            this.ptb_HinhChinh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.pnl_HinhCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P10)).BeginInit();
            this.pnl_HinhChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhChinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadImage
            // 
            this.btn_LoadImage.Location = new System.Drawing.Point(17, 37);
            this.btn_LoadImage.Name = "btn_LoadImage";
            this.btn_LoadImage.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadImage.TabIndex = 17;
            this.btn_LoadImage.Text = "Load Image";
            this.btn_LoadImage.UseVisualStyleBackColor = true;
            this.btn_LoadImage.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(17, 66);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 30;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(17, 95);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Location = new System.Drawing.Point(4, 15);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(99, 13);
            this.lbl_ThoiGian.TabIndex = 32;
            this.lbl_ThoiGian.Text = "Thời gian: 00:00:00";
            // 
            // tm_ThoiGian
            // 
            this.tm_ThoiGian.Interval = 1000;
            this.tm_ThoiGian.Tick += new System.EventHandler(this.tm_ThoiGian_Tick);
            // 
            // pnl_HinhCat
            // 
            this.pnl_HinhCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_HinhCat.Controls.Add(this.ptb_P13);
            this.pnl_HinhCat.Controls.Add(this.ptb_P03);
            this.pnl_HinhCat.Controls.Add(this.ptb_P06);
            this.pnl_HinhCat.Controls.Add(this.ptb_P09);
            this.pnl_HinhCat.Controls.Add(this.ptb_P12);
            this.pnl_HinhCat.Controls.Add(this.ptb_P02);
            this.pnl_HinhCat.Controls.Add(this.ptb_P05);
            this.pnl_HinhCat.Controls.Add(this.ptb_P08);
            this.pnl_HinhCat.Controls.Add(this.ptb_P11);
            this.pnl_HinhCat.Controls.Add(this.ptb_P01);
            this.pnl_HinhCat.Controls.Add(this.ptb_P04);
            this.pnl_HinhCat.Controls.Add(this.ptb_P07);
            this.pnl_HinhCat.Controls.Add(this.ptb_P10);
            this.pnl_HinhCat.Location = new System.Drawing.Point(6, 5);
            this.pnl_HinhCat.Name = "pnl_HinhCat";
            this.pnl_HinhCat.Size = new System.Drawing.Size(309, 483);
            this.pnl_HinhCat.TabIndex = 33;
            // 
            // ptb_P13
            // 
            this.ptb_P13.AccessibleName = "p13";
            this.ptb_P13.BackColor = System.Drawing.Color.Black;
            this.ptb_P13.Location = new System.Drawing.Point(201, 379);
            this.ptb_P13.Name = "ptb_P13";
            this.ptb_P13.Size = new System.Drawing.Size(99, 94);
            this.ptb_P13.TabIndex = 42;
            this.ptb_P13.TabStop = false;
            this.ptb_P13.Click += new System.EventHandler(this.ptb_P13_Click);
            // 
            // ptb_P03
            // 
            this.ptb_P03.AccessibleName = "p03";
            this.ptb_P03.BackColor = System.Drawing.Color.Black;
            this.ptb_P03.Location = new System.Drawing.Point(201, 3);
            this.ptb_P03.Name = "ptb_P03";
            this.ptb_P03.Size = new System.Drawing.Size(99, 94);
            this.ptb_P03.TabIndex = 41;
            this.ptb_P03.TabStop = false;
            this.ptb_P03.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P06
            // 
            this.ptb_P06.AccessibleName = "p06";
            this.ptb_P06.BackColor = System.Drawing.Color.Black;
            this.ptb_P06.Location = new System.Drawing.Point(201, 97);
            this.ptb_P06.Name = "ptb_P06";
            this.ptb_P06.Size = new System.Drawing.Size(99, 94);
            this.ptb_P06.TabIndex = 40;
            this.ptb_P06.TabStop = false;
            this.ptb_P06.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P09
            // 
            this.ptb_P09.AccessibleName = "p09";
            this.ptb_P09.BackColor = System.Drawing.Color.Black;
            this.ptb_P09.Location = new System.Drawing.Point(201, 191);
            this.ptb_P09.Name = "ptb_P09";
            this.ptb_P09.Size = new System.Drawing.Size(99, 94);
            this.ptb_P09.TabIndex = 39;
            this.ptb_P09.TabStop = false;
            this.ptb_P09.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P12
            // 
            this.ptb_P12.AccessibleName = "p12";
            this.ptb_P12.BackColor = System.Drawing.Color.Black;
            this.ptb_P12.Location = new System.Drawing.Point(201, 285);
            this.ptb_P12.Name = "ptb_P12";
            this.ptb_P12.Size = new System.Drawing.Size(99, 94);
            this.ptb_P12.TabIndex = 38;
            this.ptb_P12.TabStop = false;
            this.ptb_P12.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P02
            // 
            this.ptb_P02.AccessibleName = "p02";
            this.ptb_P02.BackColor = System.Drawing.Color.Black;
            this.ptb_P02.Location = new System.Drawing.Point(102, 3);
            this.ptb_P02.Name = "ptb_P02";
            this.ptb_P02.Size = new System.Drawing.Size(99, 94);
            this.ptb_P02.TabIndex = 37;
            this.ptb_P02.TabStop = false;
            this.ptb_P02.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P05
            // 
            this.ptb_P05.AccessibleName = "p05";
            this.ptb_P05.BackColor = System.Drawing.Color.Black;
            this.ptb_P05.Location = new System.Drawing.Point(102, 97);
            this.ptb_P05.Name = "ptb_P05";
            this.ptb_P05.Size = new System.Drawing.Size(99, 94);
            this.ptb_P05.TabIndex = 36;
            this.ptb_P05.TabStop = false;
            this.ptb_P05.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P08
            // 
            this.ptb_P08.AccessibleName = "p08";
            this.ptb_P08.BackColor = System.Drawing.Color.Black;
            this.ptb_P08.Location = new System.Drawing.Point(102, 191);
            this.ptb_P08.Name = "ptb_P08";
            this.ptb_P08.Size = new System.Drawing.Size(99, 94);
            this.ptb_P08.TabIndex = 35;
            this.ptb_P08.TabStop = false;
            this.ptb_P08.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P11
            // 
            this.ptb_P11.AccessibleName = "p11";
            this.ptb_P11.BackColor = System.Drawing.Color.Black;
            this.ptb_P11.Location = new System.Drawing.Point(102, 285);
            this.ptb_P11.Name = "ptb_P11";
            this.ptb_P11.Size = new System.Drawing.Size(99, 94);
            this.ptb_P11.TabIndex = 34;
            this.ptb_P11.TabStop = false;
            this.ptb_P11.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P01
            // 
            this.ptb_P01.AccessibleName = "p01";
            this.ptb_P01.BackColor = System.Drawing.Color.Black;
            this.ptb_P01.Location = new System.Drawing.Point(3, 3);
            this.ptb_P01.Name = "ptb_P01";
            this.ptb_P01.Size = new System.Drawing.Size(99, 94);
            this.ptb_P01.TabIndex = 33;
            this.ptb_P01.TabStop = false;
            this.ptb_P01.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P04
            // 
            this.ptb_P04.AccessibleName = "p04";
            this.ptb_P04.BackColor = System.Drawing.Color.Black;
            this.ptb_P04.Location = new System.Drawing.Point(3, 97);
            this.ptb_P04.Name = "ptb_P04";
            this.ptb_P04.Size = new System.Drawing.Size(99, 94);
            this.ptb_P04.TabIndex = 32;
            this.ptb_P04.TabStop = false;
            this.ptb_P04.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P07
            // 
            this.ptb_P07.AccessibleName = "p07";
            this.ptb_P07.BackColor = System.Drawing.Color.Black;
            this.ptb_P07.Location = new System.Drawing.Point(3, 191);
            this.ptb_P07.Name = "ptb_P07";
            this.ptb_P07.Size = new System.Drawing.Size(99, 94);
            this.ptb_P07.TabIndex = 31;
            this.ptb_P07.TabStop = false;
            this.ptb_P07.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // ptb_P10
            // 
            this.ptb_P10.AccessibleName = "p10";
            this.ptb_P10.BackColor = System.Drawing.Color.Black;
            this.ptb_P10.Location = new System.Drawing.Point(3, 285);
            this.ptb_P10.Name = "ptb_P10";
            this.ptb_P10.Size = new System.Drawing.Size(99, 94);
            this.ptb_P10.TabIndex = 30;
            this.ptb_P10.TabStop = false;
            this.ptb_P10.Click += new System.EventHandler(this.ptb_P01_Click);
            // 
            // pnl_HinhChinh
            // 
            this.pnl_HinhChinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_HinhChinh.Controls.Add(this.ptb_HinhChinh);
            this.pnl_HinhChinh.Location = new System.Drawing.Point(326, 5);
            this.pnl_HinhChinh.Name = "pnl_HinhChinh";
            this.pnl_HinhChinh.Size = new System.Drawing.Size(210, 255);
            this.pnl_HinhChinh.TabIndex = 34;
            // 
            // ptb_HinhChinh
            // 
            this.ptb_HinhChinh.BackColor = System.Drawing.Color.Black;
            this.ptb_HinhChinh.Location = new System.Drawing.Point(4, 4);
            this.ptb_HinhChinh.Name = "ptb_HinhChinh";
            this.ptb_HinhChinh.Size = new System.Drawing.Size(197, 243);
            this.ptb_HinhChinh.TabIndex = 16;
            this.ptb_HinhChinh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ThoiGian);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.btn_LoadImage);
            this.groupBox1.Location = new System.Drawing.Point(375, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 127);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // btn_Info
            // 
            this.btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Info.BackgroundImage")));
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Info.Location = new System.Drawing.Point(502, 464);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(27, 24);
            this.btn_Info.TabIndex = 36;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Help.BackgroundImage")));
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.Location = new System.Drawing.Point(469, 464);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(27, 24);
            this.btn_Help.TabIndex = 37;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 492);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_HinhChinh);
            this.Controls.Add(this.pnl_HinhCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xếp Hình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_HinhCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_P10)).EndInit();
            this.pnl_HinhChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhChinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadImage;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private System.Windows.Forms.Timer tm_ThoiGian;
        private System.Windows.Forms.Panel pnl_HinhCat;
        private System.Windows.Forms.PictureBox ptb_P13;
        private System.Windows.Forms.PictureBox ptb_P03;
        private System.Windows.Forms.PictureBox ptb_P06;
        private System.Windows.Forms.PictureBox ptb_P09;
        private System.Windows.Forms.PictureBox ptb_P12;
        private System.Windows.Forms.PictureBox ptb_P02;
        private System.Windows.Forms.PictureBox ptb_P05;
        private System.Windows.Forms.PictureBox ptb_P08;
        private System.Windows.Forms.PictureBox ptb_P11;
        private System.Windows.Forms.PictureBox ptb_P01;
        private System.Windows.Forms.PictureBox ptb_P04;
        private System.Windows.Forms.PictureBox ptb_P07;
        private System.Windows.Forms.PictureBox ptb_P10;
        private System.Windows.Forms.Panel pnl_HinhChinh;
        private System.Windows.Forms.PictureBox ptb_HinhChinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Help;
    }
}

