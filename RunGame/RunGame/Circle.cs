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
                : this(new Point(x, y), r)
        {
        }

        public Circle(Point p, int r)
        {
            Center = p;
            Radius = r;
            Color = Color.Blue;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Gole()
        {
            Color = Color.Red;
        }

        public void NoGole()
        {
            Color = Color.Blue;
        }

        public bool IsCatch(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
