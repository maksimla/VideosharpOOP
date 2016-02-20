using System.Drawing;

namespace RunGame
{
    public class Circle : IPlayer
    {
        public Point Center { get; private set; }
        public int Radius { get; private set; }
        public Color Color { get; private set; }
        public Point corner;
        public int width;
        public int height;

        private Pen Pen;

        public Circle(int x, int y, int r)
                : this(new Point(x, y), r)
        {
        }

        public Circle(Point p, int r)
        {
            /*Center = p;
            Radius = r;*/
            Color = Color.Blue;
            Pen=new Pen(Color,2);
            Center = p;
            Radius = r;
            corner = new Point(Center.X - Radius, Center.Y - Radius);
            width = height = Radius * 2;
        }

        public void Run()
        {
           
        }

        public void Gole()
        {
            Color = Color.Red; //throw new System.NotImplementedException();
            Pen.Color = Color;
        }

        public void NoGole()
        {
            Color = Color.Blue; //throw new System.NotImplementedException();
            Pen.Color = Color;
        }

        public bool IsCatch(object obj)
        {
            throw new System.NotImplementedException();
        }

        public void Draw(Graphics graph)
        {
            graph.DrawEllipse(Pen, corner.X, corner.Y, width, height);
        }
    }
}
