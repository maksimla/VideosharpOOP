using System.Drawing;

namespace RunGame
{
    internal class Box : IPlayer
    {
        public Rectangle Rectangle { get; private set; }
        public Color Color { get; private set; }
        private int _sx;
        private int _sy;
        private readonly Crosser _crosser;

        public Box(int x, int y, int w, int h)
            : this(x, y, w, h, 0, 0)
        {
        }

        public Box(int x, int y, int w, int h, int sx, int sy)
        {
            Rectangle = new Rectangle(x, y, w, h);
            Color = Color.Green;
            _sx = sx;
            _sy = sy;
            _crosser = new Crosser();
        }

        public void Run()
        {
            Move();
        }

        private void Move()
        {
            int x = Rectangle.X + _sx;
            int y = Rectangle.Y + _sy;
            if (x < 0 || x > Arena.Range.Width - Rectangle.Width)
                _sx = -_sx;
            if (y < 0 || y > Arena.Range.Height - Rectangle.Height)
                _sy = -_sy;
            Rectangle = new Rectangle(Rectangle.X + _sx, Rectangle.Y + _sy, Rectangle.Width, Rectangle.Height);
        }

        public void Gole()
        {
            Color = Color.Red;
        }

        public void NoGole()
        {
            Color = Color.Green;
        }

        public bool IsCatch(IPlayer that)
        {
            return _crosser.Cross(this, that);
        }
    }
}
