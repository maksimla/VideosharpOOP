using System;
using System.Drawing;
using System.Windows.Forms;

namespace RunGame
{
    class Arena
    {
        public static Size Range { get; private set; }
        private static Random _random = new Random();

        private PictureBox _picture;
        private Graphics graphics;

        public Arena(PictureBox picture)
        {
            _picture = picture;
            Range = _picture.Size;
            _picture.Image = new Bitmap(Range.Width, Range.Height);
            graphics = Graphics.FromImage(_picture.Image);
            Clear();
        }

        private void Clear()
        {
            graphics.Clear(_picture.BackColor);
        }

        public void Show(Circle circle)
        {
            graphics.DrawEllipse(new Pen(circle.Color),
                                 circle.Center.X - circle.Radius,
                                 circle.Center.Y - circle.Radius,
                                 2 * circle.Radius,
                                 2 * circle.Radius
                                 );
        }

        public void Refresh()
        {
            _picture.Refresh();
        }

        public static Circle NewCircle()
        {
            int r = _random.Next(Range.Width / 50, Range.Width / 20);
            int x = _random.Next(r, Range.Width - r);
            int y = _random.Next(r, Range.Height - r);
            return new Circle(x, y, r);
        }
    }
}
