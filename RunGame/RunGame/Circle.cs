using System.Drawing;

namespace RunGame
{
    class Circle
    {
        public Point Center { get; private set; }
        public int Radius { get; private set; }
        public Color Color { get; private set; }

        public Circle(int x, int y, int r)
                : this(new Point(x, y), r)
        {
        }

        public Circle(Point p, int r)
        {
            Center = p;
            Radius = r;
            Color = Color.Blue;
        }
    }
}
