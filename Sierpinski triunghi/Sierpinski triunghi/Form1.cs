using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierpinski_triunghi
{
    public partial class Form1 : Form
    {
        // Draw a triangle between the points.
        private void DrawTriangle(Graphics gr, int level,
            PointF top_point, PointF left_point, PointF right_point)
        {
            // See if we should stop.
            if (level == 0)
            {
                // Fill the triangle.
                PointF[] points =
                {
            top_point, right_point, left_point
        };
                gr.FillPolygon(Brushes.Red, points);
            }
            else
            {
                // Find the edge midpoints.
                PointF left_mid = new PointF(
                    (top_point.X + left_point.X) / 2f,
                    (top_point.Y + left_point.Y) / 2f);
                PointF right_mid = new PointF(
                    (top_point.X + right_point.X) / 2f,
                    (top_point.Y + right_point.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (left_point.X + right_point.X) / 2f,
                    (left_point.Y + right_point.Y) / 2f);

                // Recursively draw smaller triangles.
                DrawTriangle(gr, level - 1,
                    top_point, left_mid, right_mid);
                DrawTriangle(gr, level - 1,
                    left_mid, left_point, bottom_mid);
                DrawTriangle(gr, level - 1,
                    right_mid, bottom_mid, right_point);
            }
        }


        public static partial class Engine
        {
            #region graphics
            public static Bitmap bmp;
            public static Graphics grp;
            public static Color backColor = Color.Pink;
            public static int resx, resy;
            public static PictureBox display;
            public static void initGraph(PictureBox T)
            {
                display = T;
                //ia toata inaltimea si latimea PictureBox-ului
                resx = display.Width;
                resy = display.Height;
                // A Bitmap is an object used to work with images defined by pixel data.
                bmp = new Bitmap(resx, resy);
                //Create graphics object for alteration.
                grp = Graphics.FromImage(bmp);
                clearGraph();
                //Immediately redraws the plot area.
                refreshGraph();
            }
            public static void refreshGraph()
            {
                display.Image = bmp;
            }
            public static void clearGraph()
            {
                grp.Clear(backColor);
            }
            public static void drawTriangle(Color draw, PointF A, PointF B, PointF C)
            {

                Pen drawColor = new Pen(draw,1);

                grp.DrawLine(drawColor, A, B);
                grp.DrawLine(drawColor, A, C);
                grp.DrawLine(drawColor, B, C);
            }
            public static void fillTriangle(Color fill, PointF A, PointF B, PointF C)
            {
                SolidBrush fillColor = new SolidBrush(fill);
                PointF[] P = new PointF[] { A, B, C };
                grp.FillPolygon(fillColor, P);
            }
            #endregion
        }
    public static partial class Engine
    {
        #region math
        public static float dEuclid(PointF A, PointF B)
        {
            return (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
        public static PointF midllePoint(PointF A, PointF B)
        {
            return new PointF((1 * A.X + 1 * B.X) / (1 + 1), (1 * A.Y + 1 * B.Y) / (1 + 1));
        }

        public static PointF poundPoint(PointF A, float pA, PointF B, float pB)
        {
            return new PointF((pA * A.X + pB * B.X) / (pA + pB), (pA * A.Y + pB * B.Y) / (pA + pB));
        }

        public static PointF[] midllePointPoly(PointF[] p)
        {
            PointF[] tor = new PointF[p.Length];
            for (int i = 0; i < p.Length - 1; i++)
                tor[i] = midllePoint(p[i], p[i + 1]);
            tor[p.Length - 1] = midllePoint(p[p.Length - 1], p[0]);
            return tor;
        }
        public static PointF[] poundPointPoly(PointF[] p, float pA, float pB)
        {
            PointF[] tor = new PointF[p.Length];
            for (int i = 0; i < p.Length - 1; i++)
                tor[i] = poundPoint(p[i], pA, p[i + 1], pB);
            tor[p.Length - 1] = poundPoint(p[p.Length - 1], pA, p[0], pB);
            return tor;
        }

        static float signedTriangleAreea(PointF A, PointF B, PointF C)
        {
                //determinantul ariei
            return (A.X * B.Y + B.X * C.Y + C.X * A.Y - B.Y * C.X - C.Y * A.X - A.Y * B.X) * 0.5f;
        }
        public static float ariaPoly(PointF[] p)
        {
            PointF O = new PointF(0, 0);
            float tor = 0;
            for (int i = 0; i < p.Length - 1; i++)
                tor += signedTriangleAreea(p[i], p[i + 1], O);
            tor += signedTriangleAreea(p[p.Length - 1], p[0], O);
            return Math.Abs(tor);
        }
        #endregion
    }
    public static partial class Engine
    {
        #region random
        public static Random rnd = new Random();
        public static Color getRNDColor()
        {
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        public static PointF getRNDPointF()
        {
            return new PointF(rnd.Next(resx), rnd.Next(resy));
        }
        #endregion
    }
    
    public Form1()
        {
            InitializeComponent();
        }
        PointF[] p;
        int n = 3; //nr de laturi ale poligonului
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.initGraph(pictureBox1);

            p = new PointF[n];
            for (int i = 0; i < n; i++)
                p[i] = Engine.getRNDPointF();

            polyDeriv(p);

            Engine.refreshGraph();
        }
        //de aici schimb culoarea contururilor (pen-ului
         public void polyDeriv(PointF[] p)
        {
            if (Engine.ariaPoly(p) > 50)
            {
                Engine.grp.DrawPolygon(new Pen(Color.Blue), p);
                //raportul de impartire a poligonului
                polyDeriv(Engine.poundPointPoly(p, 2, 2));
            }

        }
        public void Sierpinski(PointF A, PointF B, PointF C)
        {
            if ((Engine.dEuclid(A, B) >= 1) && (Engine.dEuclid(A, C) >= 1) && (Engine.dEuclid(B, C) >= 1))
            {
                Engine.drawTriangle(Engine.getRNDColor(), A, B, C);
                Engine.fillTriangle(Engine.getRNDColor(), A, B, C);

                PointF M = Engine.midllePoint(A, B);
                PointF N = Engine.midllePoint(A, C);
                PointF P = Engine.midllePoint(B, C);

                Sierpinski(A, M, N);
                Sierpinski(B, M, P);
                Sierpinski(C, N, P);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
