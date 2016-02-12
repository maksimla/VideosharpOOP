using System;
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

        Circle circle1;
        Circle circle2;
        Circle circle3;
        Line line1;
        Line line2;
        Box box1;
        Box box2;

        ColorCircle circle21;
        ColorCircle circle22;
        ColorCircle circle23;
        ColorLine line21;
        ColorLine line22;
        ColorBox box21;
        ColorBox box22;

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

            circle1 = new Circle(A, D);
            circle2 = new Circle(B, D);
            circle3 = new Circle(C, E);

            line1 = new Line(F, G);
            line2 = new Line(H, I);

            box1 = new Box(J, K);
            box2 = new Box(L, M);

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

            circle21 = new ColorCircle(A, D, Color.DarkOrchid);
            circle22 = new ColorCircle(B, D, Color.Aquamarine);
            circle23 = new ColorCircle(C, E, Color.BlanchedAlmond);

            line21 = new ColorLine(F, G, Color.BlueViolet);
            line22 = new ColorLine(H, I, Color.DarkGoldenrod);

            box21 = new ColorBox(J, K, Color.DeepSkyBlue);
            box22 = new ColorBox(L, M, Color.Chocolate);

        }

        private void Draw()
        {
            Draw(circle1);
            Draw(circle2);
            Draw(circle3);
            Draw(line1);
            Draw(line2);
            Draw(box1);
            Draw(box2);

            Draw(circle21);
            Draw(circle22);
            Draw(circle23);
            Draw(line21);
            Draw(line22);
            Draw(box21);
            Draw(box22);
            picture.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(ColorLine line)
        {
            graph.DrawLine(line.pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(ColorBox box)
        {
            graph.DrawRectangle(box.pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }

        private void Draw(ColorCircle circle)
        {
            graph.DrawEllipse(circle.pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }
    }
}
