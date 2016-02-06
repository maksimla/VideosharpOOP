using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        Line line1;
        Line line2;
        Bitmap bmp;
        Graphics graph;
        Pen pen;

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
            pen = new Pen(Color.Blue);
            line1 = new Line(100, 100, 200, 10);
            line2 = new Line(200, 10, 300, 100);
        }

        private void Draw()
        {
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            Draw(line1);
            Draw(line2);
            picture.Image = bmp;
        }

        private void Draw(Line line)
        {
            graph.DrawLine(pen, line.x1, line.y1, line.x2, line.y2);
        }
    }
}
