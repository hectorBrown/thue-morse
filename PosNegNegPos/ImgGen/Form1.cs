using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ImgGen
{
    public partial class Form1 : Form
    {
        string current = "1";
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void Init()
        {
            current = PosNegNegPos(current);
            //Bitmap bmp = new Bitmap(Convert.ToInt32(Math.Sqrt(current.Length)), Convert.ToInt32(Math.Sqrt(current.Length)));
            Bitmap bmp = new Bitmap(1920, 1080);
            GenBmp(current, ref bmp);
            PB_main.Image = bmp;
            bmp.Save("output" + i + ".bmp");
            i++;
            //PB_main.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_main.CreateGraphics().InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            PB_main.Refresh();
        }
        string PosNegNegPos(string input)
        {
            string inverted = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == '1')
                {
                    inverted += "0";
                }
                else
                {
                    inverted += "1";
                }
            }
            string output = input + inverted + inverted + input;
            return output;
        }
        void ExportToCsv(string path, string input)
        {
            StreamWriter strW = new StreamWriter(path);
            for (int i = 0; i <= input.Length - 1; i++)
            {
                strW.WriteLine(input[i] + ",");
            }
            strW.Close();
        }
        void ExportToTxt(string path, string input)
        {
            StreamWriter strW = new StreamWriter(path);
            strW.WriteLine(input);
            strW.Close();
        }
        void GenBmp(string input, ref Bitmap bmp)
        {
            int counter = 0;
            Graphics g = Graphics.FromImage(bmp);
            //g.FillRectangle(new SolidBrush(Color.FromArgb(43, 102, 59)), 0, 0, 1920, 1080);
            for (int x = 0; x <= bmp.Width - 1; x += 10)
            {
                for (int y = 0; y <= bmp.Height - 1; y += 10)
                {
                    if (counter <= input.Length - 1)
                    {
                        if (input[counter] == '0')
                        {
                            g.FillEllipse(new SolidBrush(Color.FromArgb(255,255,255)), new Rectangle(x, y, 10, 10));
                        }
                    }
                    counter++;
                }
            }
        }

        private void TIM_init_Tick(object sender, EventArgs e)
        {
            Init();
        }
    }
}