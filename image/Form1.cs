using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pic;
        Bitmap origPic;
        Bitmap grayPic;
        Bitmap redPic;
        Bitmap greenPic;
        Bitmap bluePic;
        Bitmap turnPic;
        public int rgb;
        public int controlTrack = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            value_label.Text = "null";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //trackBar歸位
                controlTrack = 1;
                trackBar1.Value = 0;
                controlTrack = 0;

                //開啟的圖檔存在pic
                pic = new Bitmap(openFileDialog1.FileName);
                panel1.BackgroundImage = pic;
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
                panel1.Refresh();

                rgb = 0;
                int H = pic.Height;
                int W = pic.Width;
                origPic = new Bitmap(W, H);
                grayPic = new Bitmap(W, H);
                redPic = new Bitmap(W, H);
                greenPic = new Bitmap(W, H);
                bluePic = new Bitmap(W, H);
                turnPic = new Bitmap(W, H);
                origPic = pic;

                for (int y = 0; y < H; ++y)
                {
                    for (int x = 0; x < W; ++x)
                    {
                        Color picrgb = pic.GetPixel(x, y);
                        int R = picrgb.R;
                        int G = picrgb.G;
                        int B = picrgb.B;
                        int gray = (R + G + B) / 3;
                        Color ggray = Color.FromArgb(gray, gray, gray);
                        grayPic.SetPixel(x, y, ggray);
                        Color rred = Color.FromArgb(R, 0, 0);
                        redPic.SetPixel(x, y, rred);
                        Color ggren = Color.FromArgb(0, G, 0);
                        greenPic.SetPixel(x, y, ggren);
                        Color bblue = Color.FromArgb(0, 0, B);
                        bluePic.SetPixel(x, y, bblue);
                        Color tturn = Color.FromArgb(255 - R, 255 - G, 255 - B);
                        turnPic.SetPixel(x, y, tturn);
                    }
                }
            }
        }

        private void Original_Click(object sender, EventArgs e)
        {
            rgb = 5;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = pic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            value_label.Text = "" + trackBar1.Value;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (controlTrack == 0)
            {
                Bitmap trackPic = new Bitmap(pic.Width, pic.Height);
                Color tra;
                for (int y = 0; y < trackPic.Height; ++y)
                {
                    for (int x = 0; x < trackPic.Width; ++x)
                    {
                        switch (rgb)
                        {
                            case 0:
                                tra = grayPic.GetPixel(x, y);
                                break;
                            case 1:
                                tra = redPic.GetPixel(x, y);
                                break;
                            case 2:
                                tra = greenPic.GetPixel(x, y);
                                break;
                            case 3:
                                tra = bluePic.GetPixel(x, y);
                                break;
                            case 4:
                                tra = turnPic.GetPixel(x, y);
                                break;
                            case 5:
                                tra = origPic.GetPixel(x, y);
                                break;
                            default:
                                tra = grayPic.GetPixel(x, y);
                                break;
                        }

                        int R = tra.R;
                        int G = tra.G;
                        int B = tra.B;
                        if (R >= trackBar1.Value)
                            R = 255;
                        else
                            R = 0;
                        if (G >= trackBar1.Value)
                            G = 255;
                        else
                            G = 0;
                        if (B >= trackBar1.Value)
                            B = 255;
                        else B = 0;
                        Color trat = Color.FromArgb(R, G, B);
                        trackPic.SetPixel(x, y, trat);
                    }
                }
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
                panel1.BackgroundImage = trackPic;
            }
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            rgb = 0;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = grayPic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            rgb = 1;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = redPic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            rgb = 2;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = greenPic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            rgb = 3;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = bluePic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }

        private void Turn_Click(object sender, EventArgs e)
        {
            rgb = 4;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BackgroundImage = turnPic;
            value_label.Text = "null";
            controlTrack = 1;
            trackBar1.Value = 0;
            controlTrack = 0;
        }
    }
}
