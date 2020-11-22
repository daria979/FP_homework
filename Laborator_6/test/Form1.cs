using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        int[,] a;
        int[,] b;

        Bitmap sursa;
        Bitmap destinatie;

        public Form1()
        {
            InitializeComponent();
        }

        void load()
        {
            TextReader dataLoad = new StreamReader(@"..\..\Data.in");
            string buffer = dataLoad.ReadLine();
            int n = int.Parse(buffer.Split(' ')[0]);
            int m = int.Parse(buffer.Split(' ')[1]);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                buffer = dataLoad.ReadLine();
                string[] local = buffer.Split(' ');
                for (int j = 0; j < m; j++)
                    a[i, j] = int.Parse(local[j]);
            }
            dataLoad.Close();
        }

        void view(int [,] T) 
        {
            int n = T.GetLength(0);
            int m = T.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                string buffer = "";
                for (int j = 0; j < m; j++)
                    buffer += T[i, j] + " ";
                listBox1.Items.Add(buffer);
            }
        }

        void doMath() 
        {
            int n = a.GetLength (0);
            int m = a.GetLength (1);
            b = new int[2 * n - 1, 2 * m - 1];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    b[i * 2, j * 2] = a[i, j];

            for (int i = 0; i < n * 2 - 1; i += 2)
                for (int j = 1; j < 2 * m - 1; j += 2)
                    b[i, j] = (b[i, j - 1] + b[i, j + 1]) / 2;

            for (int i = 1; i < n * 2 - 1; i += 2)
                for (int j = 0; j < 2 * m - 1; j ++)
                    b[i, j] = (b[i-1, j ] + b[i + 1, j]) / 2;
        }

        void zoom() 
        {
            destinatie = new Bitmap(sursa.Width * 2 - 1, sursa.Height * 2 - 1);
            for (int i = 0; i < sursa.Width ; i ++ )
                for (int j = 0; j < sursa.Height; j++)
                    destinatie.SetPixel (i * 2, j * 2, sursa.GetPixel (i, j));
            for (int i = 0; i < sursa.Width * 2 - 1; i += 2)
                for (int j = 1; j < sursa.Height * 2 - 1; j += 2)
                {
                    Color t1 = destinatie.GetPixel (i, j - 1);
                    Color t2 = destinatie.GetPixel (i, j + 1);
                    int r = (t1.R + t2.R )/2;
                    int g = (t1.G + t2.G )/2;
                    int b = (t1.B + t2.B )/2;
                    
                    destinatie.SetPixel(i, j, Color.FromArgb (r,g,b));
                }

            for (int i = 1; i < sursa.Width * 2 - 1; i += 2)
                for (int j = 0; j < sursa.Height * 2 - 1; j++)
                {
                    Color t1 = destinatie.GetPixel(i - 1, j );
                    Color t2 = destinatie.GetPixel(i + 1, j);
                    int r = (t1.R + t2.R) / 2;
                    int g = (t1.G + t2.G) / 2;
                    int b = (t1.B + t2.B) / 2;
                    destinatie.SetPixel(i, j, Color.FromArgb(r, g, b));
                }


            pictureBox2.Image = destinatie;
        }

        void grayscalle() 
        {
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0 ; i < sursa.Width ; i ++ )
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color S = sursa.GetPixel(i, j);
                    int t = (S.R + S.G + S.B)/3;
                    Color D = Color.FromArgb (t,t,t);
                    destinatie.SetPixel(i, j, D);
                }
            pictureBox2.Image = destinatie;
        }

        void test()
        {
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0; i < sursa.Width; i++)
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color S = sursa.GetPixel(i, j);
                    Color D = Color.FromArgb(S.B, S.R, S.G);
                    destinatie.SetPixel(i, j, D);
                }
            pictureBox2.Image = destinatie;
        }

        void bw()
        {
            Color S, D;
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            for (int i = 0 ; i < sursa.Width; i ++)
                for (int j = 0; j < sursa.Height; j++)
                {
                    S = sursa.GetPixel(i, j);
                    int t = (S.R + S.G + S.B) / 3;
                    if (t < 70)
                        D = Color.FromArgb(255, 0, 0);
                    else if (t >= 70 && t <= 128)
                        D = Color.FromArgb(255, 255, 0);

                    else
                        D = Color.FromArgb(0, 0, 255);
                    destinatie.SetPixel(sursa.Width - i - 1, j, D);
                }
            pictureBox2.Image = destinatie;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sursa = new Bitmap(@"..\..\Resurse\butterfly.png");
            pictureBox1.Image = sursa;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grayscalle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test();
        }

        private void btn_zoom_Click(object sender, EventArgs e)
        {
            zoom();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
