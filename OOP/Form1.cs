using System.Drawing;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen, 100, 100, 200, 200);
            graph.DrawLine(pen, 100, 100, 200, 10);
            graph.DrawLine(pen, 200, 10, 300, 100);
            picture.Image = bmp;
        }
    }
}
