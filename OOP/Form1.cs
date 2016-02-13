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

        Circle circle;
        Box box;
        Line line;

        Sprite snowMan1;
        Sprite snowMan2;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;

        private void buttonMoveMe_Click(object sender, EventArgs e)
        {
            snowMan1.Move(new Pixel(100, 100));
            snowMan1.Draw();


            picture.Image = bmp;
        }

        public Form1()
        {
            InitializeComponent();
            Init();
            InitSnowMan1();
            //InitSnowMan2();
            // Demo();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            graph = Graphics.FromImage(bmp);
        }

        private void Demo()
        {
            Pixel p = new Pixel(100, 100);
            A = new Pixel(0, 0);
            circle = new Circle(A, 20);
            circle.SetGraphics(graph);
            circle.Move(p);
            circle.Draw();

            line = new Line(0, 20, 0, 100);
            line.SetGraphics(graph);
            line.Move(p);
            line.Draw();

            box = new Box(-20, -20, 20, -40);
            box.SetGraphics(graph);
            box.Move(p);
            box.Draw();

            picture.Image = bmp;
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

            snowMan1 = new Sprite();
            snowMan1.SetGraphics(graph);

            snowMan1.AddShape(new Circle(A, D));
            snowMan1.AddShape(new Circle(B, D));
            snowMan1.AddShape(new Circle(C, E));
            snowMan1.AddShape(new Line(F, G));
            snowMan1.AddShape(new Line(H, I));
            snowMan1.AddShape(new Box(J, K));
            snowMan1.AddShape(new Box(L, M));
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

            snowMan2 = new Sprite();
            snowMan2.SetGraphics(graph);

            snowMan2.AddShape(new ColorCircle(A, D, Color.DarkOrchid));
            snowMan2.AddShape(new ColorCircle(B, D, Color.Aquamarine));
            snowMan2.AddShape(new ColorCircle(C, E, Color.BlanchedAlmond));

            snowMan2.AddShape(new ColorLine(F, G, Color.BlueViolet));
            snowMan2.AddShape(new ColorLine(H, I, Color.DarkGoldenrod));

            snowMan2.AddShape(new ColorBox(J, K, Color.DeepSkyBlue));
            snowMan2.AddShape(new ColorBox(L, M, Color.Chocolate));
        }

        private void Draw()
        {
            snowMan1.Draw();
            // snowMan2.Draw();

            picture.Image = bmp;
        }
    }
}
