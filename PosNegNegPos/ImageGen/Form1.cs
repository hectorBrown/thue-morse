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

namespace ImageGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Init()
        {
            string current = "1";
            while (true)
            {
                current = PosNegNegPos(current);
                Bitmap bmp = new Bitmap(Convert.ToInt32(Math.Sqrt(current.Length)), Convert.ToInt32(Math.Sqrt(current.Length)));
                PB_main.Image = bmp;
                PB_main.SizeMode = PictureBoxSizeMode.StretchImage;
                PB_main.Refresh();
            }
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
            for (int x = 0; x <= bmp.Width - 1; x++)
            {
                for (int y = 0; y <= bmp.Height - 1; y++)
                {
                    if (input[counter] == '1')
                    {
                        bmp.SetPixel(x, y, Color.Red);
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Blue);
                    }
                    counter++;
                }
            }
        }

        private void TIM_init_Tick(object sender, EventArgs e)
        {
            TIM_init.Enabled = false;
            Init();
        }
    }
}