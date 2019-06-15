using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepHinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hh = 0, mm = 0, ss = 0;
        List<PictureBox> LstPicture = new List<PictureBox>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadImage(@"C:\Users\Admin\Pictures\10514544_587819514688864_2818176076492399599_n.jpg");
            
            ptb_P01.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P02.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P03.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P04.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P05.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P06.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P07.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P08.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P09.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P10.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P11.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P12.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_P13.SizeMode = PictureBoxSizeMode.StretchImage;

            LstPicture.Add(ptb_P01);
            LstPicture.Add(ptb_P02);
            LstPicture.Add(ptb_P03);
            LstPicture.Add(ptb_P04);
            LstPicture.Add(ptb_P05);
            LstPicture.Add(ptb_P06);
            LstPicture.Add(ptb_P07);
            LstPicture.Add(ptb_P08);
            LstPicture.Add(ptb_P09);
            LstPicture.Add(ptb_P10);
            LstPicture.Add(ptb_P11);
            LstPicture.Add(ptb_P12);
            LstPicture.Add(ptb_P13);
        }
        private void btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open file";
                ofd.Filter = "Image|*.jpg|*.png|";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(ofd.FileName);
                    //Reset thời gian
                    lbl_ThoiGian.Text = "Thời gian: 00:00:00";
                    hh = mm = ss = 0;
                    tm_ThoiGian.Stop();
                }
            }
            catch
            {
                MessageBox.Show("Không thể đọc được dữ liệu!", "Thông báo");
            }
        }
        private void tm_ThoiGian_Tick(object sender, EventArgs e)
        {
            ss++;
            if(ss == 60)
            {
                ss = 0;
                mm++;
            }
            if(mm == 60)
            {
                mm = 0;
                hh++;
            }
            string ThoiGian = (hh <= 9 ? ("0" + hh.ToString()) : hh.ToString()) + ":" + (mm <= 9 ? ("0" + mm.ToString()) : mm.ToString()) + ":" + (ss <= 9 ? ("0" + ss.ToString()) : ss.ToString());
            lbl_ThoiGian.Text = "Thời gian: " + ThoiGian;
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (ptb_HinhChinh.Image != null)
            {
                //Trộn hình
                RandomImage();
                //Reset thời gian
                lbl_ThoiGian.Text = "Thời gian: 00:00:00";
                hh = mm = ss = 0;
                tm_ThoiGian.Start();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình trước khi bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Xếp Hình\nTác giả: Nguyễn Đức Ngưu, ĐH SPKT TPHCM\nPhiên bản: 1.0.0", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kêu gấu bày cho chơi nhé!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ptb_P13_Click(object sender, EventArgs e)
        {
            if (ptb_P13.Image != null && ptb_P12.Image == null)
            {
                SwapPictureBox(ptb_P13, ptb_P12);
                if (KiemTra())
                {
                    lbl_ThoiGian.Text = "Thời gian: 00:00:00";
                    hh = mm = ss = 0;
                    tm_ThoiGian.Stop();
                    MessageBox.Show("Very good! Bạn xếp hình rất chuyên nghiệp!", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ptb_P01_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (GetPicture_Top(p) != null && GetPicture_Top(p).Image == null)
            {
                SwapPictureBox(p, GetPicture_Top(p));
            }
            else if (GetPicture_Bot(p) != null && GetPicture_Bot(p).Image == null)
            {
                SwapPictureBox(p, GetPicture_Bot(p));
            }
            else if (GetPicture_Left(p) != null && GetPicture_Left(p).Image == null)
            {
                SwapPictureBox(p, GetPicture_Left(p));
            }
            else if (GetPicture_Right(p) != null && GetPicture_Right(p).Image == null)
            {
                SwapPictureBox(p, GetPicture_Right(p));
            }
        }

        public void Set_AccessibleName()
        {
            ptb_P01.AccessibleName = "p01";
            ptb_P02.AccessibleName = "p02";
            ptb_P03.AccessibleName = "p03";
            ptb_P04.AccessibleName = "p04";
            ptb_P05.AccessibleName = "p05";
            ptb_P06.AccessibleName = "p06";
            ptb_P07.AccessibleName = "p07";
            ptb_P08.AccessibleName = "p08";
            ptb_P09.AccessibleName = "p09";
            ptb_P10.AccessibleName = "p10";
            ptb_P11.AccessibleName = "p11";
            ptb_P12.AccessibleName = "p12";
            ptb_P13.AccessibleName = "p13";
        }
        public void LoadImage(string filename)
        {
            Bitmap img = new Bitmap(filename);
            ptb_HinhChinh.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_HinhChinh.Image = (Image)img;

            int Width_Cut, Height_Cut;
            Width_Cut = img.Width / 3;
            Height_Cut = img.Height / 4;

            int x = 0, y = 0;
            int dem = 1;
            Bitmap[] image = new Bitmap[13];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x = j * Width_Cut;
                    y = i * Height_Cut;
                    image[dem++] = img.Clone(new Rectangle(x, y, Width_Cut, Height_Cut), PixelFormat.DontCare);
                }
                x = 0;
            }

            ptb_P01.Image = (Image)image[1];
            ptb_P02.Image = (Image)image[2];
            ptb_P03.Image = (Image)image[3];
            ptb_P04.Image = (Image)image[4];
            ptb_P05.Image = (Image)image[5];
            ptb_P06.Image = (Image)image[6];
            ptb_P07.Image = (Image)image[7];
            ptb_P08.Image = (Image)image[8];
            ptb_P09.Image = (Image)image[9];
            ptb_P10.Image = (Image)image[10];
            ptb_P11.Image = (Image)image[11];
            ptb_P12.Image = (Image)image[12];
            ptb_P13.Image = null;
            Set_AccessibleName();
        }
        public void RandomImage()
        {
            Random rand = new Random();
            List<int> lstRand = new List<int>();
            List<PictureBox> LstPictureRandom = new List<PictureBox>();
            
            while(lstRand.Count < 13)
            {
                lstRand.Add(rand.Next(1, 14));
                lstRand = lstRand.Distinct().ToList();
            }

            for(int i = 0; i < 13; i++)
            {
                LstPictureRandom.Add(LstPicture[lstRand[i] - 1]);
            }

            int first = 0, last = 12;
            while(first != last)
            {
                SwapPictureBox(LstPictureRandom[first], LstPictureRandom[last]);
                first++; last--;
            }

            foreach(PictureBox ptb in pnl_HinhCat.Controls)
            {
                if(ptb.AccessibleName == "p12")
                {
                    SwapPictureBox(ptb, ptb_P13);
                }
            }
        }
        public void SwapPictureBox(PictureBox p1, PictureBox p2)
        {
            PictureBox pt = new PictureBox();
            pt.Image = p1.Image;
            pt.AccessibleName = p1.AccessibleName;
            p1.Image = p2.Image;
            p1.AccessibleName = p2.AccessibleName;
            p2.Image = pt.Image;
            p2.AccessibleName = pt.AccessibleName;
        }
        public bool KiemTra()
        {
            string str = ptb_P01.AccessibleName + ptb_P02.AccessibleName + ptb_P03.AccessibleName + ptb_P04.AccessibleName + ptb_P05.AccessibleName
                + ptb_P06.AccessibleName + ptb_P07.AccessibleName + ptb_P08.AccessibleName + ptb_P09.AccessibleName + ptb_P10.AccessibleName
                + ptb_P11.AccessibleName + ptb_P12.AccessibleName + ptb_P13.AccessibleName;
            if (str == "p01p02p03p04p05p06p07p08p09p10p11p12p13") return true;
            return false;
        }
        public int Get_STT(PictureBox p)
        {
            return Convert.ToInt32(p.Name.Substring(5, 2));
        }
        public PictureBox GetPicture_Right(PictureBox p)
        {
            int pos = Get_STT(p);
            if(pos == 3 | pos == 6 | pos == 9 | pos == 12 | pos == 13)
            {
                return null;
            }
            foreach(PictureBox ptb in pnl_HinhCat.Controls)
            {
                if (Get_STT(ptb) == pos + 1) return ptb;
            }
            return null;
        }
        public PictureBox GetPicture_Left(PictureBox p)
        {
            int pos = Get_STT(p);
            if (pos == 1 | pos == 4 | pos == 7 | pos == 10 | pos == 13)
            {
                return null;
            }
            foreach (PictureBox ptb in pnl_HinhCat.Controls)
            {
                if (Get_STT(ptb) == pos - 1) return ptb;
            }
            return null;
        }
        public PictureBox GetPicture_Top(PictureBox p)
        {
            int pos = Get_STT(p);
            if (pos == 1 | pos == 2 | pos == 3)
            {
                return null;
            }
            foreach (PictureBox ptb in pnl_HinhCat.Controls)
            {
                if (Get_STT(ptb) == pos - 3) return ptb;
            }
            return null;
        }
        public PictureBox GetPicture_Bot(PictureBox p)
        {
            int pos = Get_STT(p);
            if (pos == 10 | pos == 11 | pos == 13)
            {
                return null;
            }

            if(pos == 12)
            {
                return ptb_P13;
            }
            foreach (PictureBox ptb in pnl_HinhCat.Controls)
            {
                if (Get_STT(ptb) == pos + 3) return ptb;
            }
            return null;
        }
    }
}
