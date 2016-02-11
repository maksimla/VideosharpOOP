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

        private Line line1;
        private Line line2;
        private Line line3;
        private Line line4;
        private Line line5;
        private Line line6;
        private Line line7;
        private Line line8;

        private Circle circle1;
        private Circle circle2;


        /*Circle circle1;
        Circle circle2;
        Circle circle3;
        Line line1;
        Line line2;
        Box box1;
        Box box2;*/

        /*ColorLine cl1;
        ColorLine cl2;
        ColorBox box2;
        ColorCircle circle2;*/

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, Z;

        public Form1()
        {
            InitializeComponent();
            Init();
            InitSnowMan();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Red, 2);

        }

        private void InitSnowMan()
        {
            A = new Pixel(105, 20);
            B = new Pixel(209, 20);
            C = new Pixel(303, 20);
            D = new Pixel(40, 100);
            E = new Pixel(359, 100);
            F = new Pixel(15, 140);
            G = new Pixel(57, 140);
            H = new Pixel(95, 140);
            I = new Pixel(208, 140);
            J = new Pixel(265, 140);
            K = new Pixel(301, 140);
            L = new Pixel(338, 140);
            M = new Pixel(408, 140);
            N = new Pixel(95, 175);
            O = new Pixel(302, 175);
            Z = new Pixel(130, 140);

            line1 = new Line(A, C);
            line2 = new Line(B, I);
            line3 = new Line(A, F);
            line4 = new Line(C, E);
            line5 = new Line(E, M);
            line6 = new Line(L, M);
            line7 = new Line(F, G);
            line8 = new Line(Z, J);

            circle1 = new Circle(H, N);
            circle2 = new Circle(K, O);

            /*
            A = new Pixel(219, 63);
            B = new Pixel(220,177);
            C = new Pixel(223,401);
            D = new Pixel(218,98);
            E = new Pixel(221,259);
            F = new Pixel(158,129);
            G= new Pixel(64,200);
            H= new Pixel(282,131);
            I= new Pixel(366,200);
            J= new Pixel(140,493);
            K= new Pixel(188,537);
            L= new Pixel(242,492);
            M=new Pixel(283,534);

            circle1 = new Circle(A,D);
            circle2 = new Circle(B,D);
            circle3 = new Circle(C,E);

            line1 = new Line(F,G);
            line2 = new Line(H,I);

            box1 = new Box(J,K);
            box2=new Box(L,M);*/

        }

        private void Draw()
        {
            Draw(line1);
            Draw(line2);
            Draw(line3);
            Draw(line4);
            Draw(line5);
            Draw(line6);
            Draw(line7);
            Draw(line8);
            Draw(circle1);
            Draw(circle2);

            /*Draw(circle1);
            Draw(circle2);
            Draw(circle3);
            Draw(line1);
            Draw(line2);
            Draw(box1);
            Draw(box2);*/
            /*Draw(box1);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            Draw(circle2);
           // Draw(cl1);
           // Draw(cl2);
            Draw(box2);*/
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
