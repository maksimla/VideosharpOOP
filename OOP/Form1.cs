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

        Line line1;
        Line line2;
        Box box1;
        Circle circle1;
        Circle circle2;

        Pixel A, B, C, D, E, O;

        public Form1()
        {
            InitializeComponent();
            Init();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
            pen = new Pen(Color.Green);

            A = new Pixel(100, 300);
            B = new Pixel(300, 300);
            C = new Pixel(100, 100);
            D = new Pixel(300, 100);
            E = new Pixel(200, 10);
            O = new Pixel(200, 200);

            line1 = new Line(C, E);
            line2 = new Line(E, D);
            box1 = new Box(C, B);
            circle1 = new Circle(O, 100);
            circle2 = new Circle(O, A);

        }

        private void Draw()
        {
            Draw(box1);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            Draw(circle2);
            picture.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.begin.x, line.begin.y, line.ended.x, line.ended.y);
        }

        private void Draw(Box box)
        {
            graph.DrawRectangle(pen, box.corner1.x, box.corner1.y, box.width, box.height);
        }

        private void Draw(Circle circle)
        {
            graph.DrawEllipse(pen, circle.corner.x, circle.corner.y, circle.width, circle.height);
        }
    }
}
