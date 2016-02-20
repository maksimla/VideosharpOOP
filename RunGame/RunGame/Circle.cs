using System;
using System.Drawing;

namespace RunGame
{
    class Circle : IPlayer
    {
        public Point Center { get; private set; }
        public int Radius { get; private set; }
        public Color Color { get; private set; }
        private int sx;
        private int sy;

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
            this.sx = sx;
            this.sy = sy;
        }

        public void Run()
        {
            int x = Center.X + sx;
            int y = Center.Y + sy;
            if (x < Radius || x > Arena.Range.Width - Radius)
                sx = -sx;
            if (y < Radius || y > Arena.Range.Height - Radius)
                sy = -sy;
            Center = new Point(Center.X + sx, Center.Y + sy);

        }

        public void Gole()
        {
            Color = Color.Red;
        }

        public void NoGole()
        {
            Color = Color.Blue;
        }

        public bool IsCatch(IPlayer obj)
        {
            if (obj.GetType() != typeof(Circle))
                return false;
            return Cross(this, (Circle)obj);
        }

        private bool Cross(Circle c1, Circle c2)
        {
            return distance(c1.Center, c2.Center) <= c1.Radius + c2.Radius;
        }

        private int distance(Point p, Point q)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(p.X - q.X, 2) + Math.Pow(p.Y - q.Y, 2)));
        }
    }
}
