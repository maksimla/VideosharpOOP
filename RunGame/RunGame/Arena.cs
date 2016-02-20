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
            _picture.Image=new Bitmap(Range.Width,Range.Height);
            graphics = Graphics.FromImage(_picture.Image);
            Clear();
        }

        private void Clear()
        {
            graphics.Clear(_picture.BackColor);
        }
    }
}
