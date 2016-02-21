using System.Drawing;

namespace RunGame
{
    class Circle : IPlayer
    {
        public Point Center { get; private set; }
        public int Radius { get; private set; }
        public Color Color { get; private set; }
        private int _sx;
        private int _sy;
        private readonly Crosser _crosser;

        public Circle(int x, int y, int r)
               : this(new Point(x, y), r, 0, 0)
        {
        }
        public Circle(int x, int y, int r, int sx, int sy)
                : this(new Point(x, y), r, sx, sy)
        {
        }

        public Circle(Point p, int r, int sx, int sy)
        {
            Center = p;
            Radius = r;
            Color = Color.Blue;
            _sx = sx;
            _sy = sy;
            _crosser = new Crosser();
        }

        public void Run()
        {
            int x = Center.X + _sx;
            int y = Center.Y + _sy;
            if (x < Radius || x > Arena.Range.Width - Radius)
                _sx = -_sx;
            if (y < Radius || y > Arena.Range.Height - Radius)
                _sy = -_sy;
            Center = new Point(Center.X + _sx, Center.Y + _sy);

        }

        public void Gole()
        {
            Color = Color.Red;
        }

        public void NoGole()
        {
            Color = Color.Blue;
        }

        public bool IsCatch(IPlayer that)
        {
            return _crosser.Cross(this, that);
        }
    }
}
