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
        ColorLine cl1;
        ColorLine cl2;
        Box box1;
        ColorBox box2;
        Circle circle1;
        ColorCircle circle2;

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
            pen = new Pen(Color.Green,2);

            A = new Pixel(100, 300);
            B = new Pixel(300, 300);
            C = new Pixel(100, 100);
            D = new Pixel(300, 100);
            E = new Pixel(200, 10);
            O = new Pixel(200, 200);

            line1 = new Line(C, E);
            line2 = new Line(E, D);
            box1 = new Box(C, B);
            box2= new ColorBox(O,B,Color.DarkRed);
            circle1 = new Circle(O, 100);
            circle2 = new ColorCircle(O, A,Color.Orange);

            cl1 = new ColorLine(A,D,Color.Red);
            cl2 = new ColorLine(B,C,Color.Red);

        }

        private void Draw()
        {
            Draw(box1);
            Draw(line1);
            Draw(line2);
            Draw(circle1);
            Draw(circle2);
            Draw(cl1);
            Draw(cl2);
            Draw(box2);
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
