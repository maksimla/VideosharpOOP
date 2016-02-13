﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    public struct Pixel
    {
        public int x;
        public int y;

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int distance(Pixel pixel)
        {
            return Convert.ToInt32(Math.Sqrt(
                (x - pixel.x) * (x - pixel.x) +
                (y - pixel.y) * (y - pixel.y)));
        }
    }

    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics graph;
        Pen pen;

        Shape[] snowMan1;
        Shape[] snowMan2;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;

        public Form1()
        {
            InitializeComponent();
            Init();
            InitSnowMan1();
            InitSnowMan2();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue, 2);

        }

        private void InitSnowMan1()
        {
            A = new Pixel(219, 63);
            B = new Pixel(220, 177);
            C = new Pixel(223, 401);
            D = new Pixel(218, 98);
            E = new Pixel(221, 259);
            F = new Pixel(158, 129);
            G = new Pixel(64, 200);
            H = new Pixel(282, 131);
            I = new Pixel(366, 200);
            J = new Pixel(140, 493);
            K = new Pixel(188, 537);
            L = new Pixel(242, 492);
            M = new Pixel(283, 534);

            snowMan1 = new Shape[7];

            snowMan1[0] = new Circle(A, D);
            snowMan1[1] = new Circle(B, D);
            snowMan1[2] = new Circle(C, E);
            snowMan1[3] = new Line(F, G);
            snowMan1[4] = new Line(H, I);
            snowMan1[5] = new Box(J, K);
            snowMan1[6] = new Box(L, M);


            foreach (var snowman in snowMan1)
                snowman.SetGraphics(graph);
        }

        private void InitSnowMan2()
        {
            int delta = 400;
            A = new Pixel(delta + 219, 63);
            B = new Pixel(delta + 220, 177);
            C = new Pixel(delta + 223, 401);
            D = new Pixel(delta + 218, 98);
            E = new Pixel(delta + 221, 259);
            F = new Pixel(delta + 158, 129);
            G = new Pixel(delta + 64, 200);
            H = new Pixel(delta + 282, 131);
            I = new Pixel(delta + 366, 200);
            J = new Pixel(delta + 140, 493);
            K = new Pixel(delta + 188, 537);
            L = new Pixel(delta + 242, 492);
            M = new Pixel(delta + 283, 534);

            snowMan2 = new Shape[7];

            snowMan2[0] = new ColorCircle(A, D, Color.DarkOrchid);
            snowMan2[1] = new ColorCircle(B, D, Color.Aquamarine);
            snowMan2[2] = new ColorCircle(C, E, Color.BlanchedAlmond);

            snowMan2[3] = new ColorLine(F, G, Color.BlueViolet);
            snowMan2[4] = new ColorLine(H, I, Color.DarkGoldenrod);

            snowMan2[5] = new ColorBox(J, K, Color.DeepSkyBlue);
            snowMan2[6] = new ColorBox(L, M, Color.Chocolate);

            foreach (var snowman in snowMan2)
                snowman.SetGraphics(graph);

        }

        private void Draw()
        {
            Draw(snowMan1);
            Draw(snowMan2);

            picture.Image = bmp;
        }

        public void Draw(Shape[] shapes)
        {
            foreach (var shape in shapes)
                Draw(shape);
        }

        private void Draw(Shape shape)
        {
            if (shape.GetType() == typeof(Line))
                ((Line)shape).Draw();
            if (shape.GetType() == typeof(Circle))
                ((Circle)shape).Draw();
            if (shape.GetType() == typeof(Box))
                ((Box)shape).Draw();
            if (shape.GetType() == typeof(ColorLine))
                ((ColorLine)shape).Draw();
            if (shape.GetType() == typeof(ColorCircle))
                ((ColorCircle)shape).Draw();
            if (shape.GetType() == typeof(ColorBox))
                ((ColorBox)shape).Draw();
        }
    }
}
