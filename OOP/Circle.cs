using System.Drawing;

namespace OOP
{
    class Circle : Shape
    {
        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width;
        public int height;

        protected Graphics graph;
        protected Pen pen;

        public Circle(int x, int y, int radius)
            : this(new Pixel(x, y), radius)
        {
        }

        public Circle(Pixel center, int radius)
        {
            this.center = center;
            this.radius = radius;
            corner = new Pixel(center.x - radius, center.y - radius);
            width = height = radius * 2;
        }

        public Circle(Pixel center, Pixel point)
            : this(center, center.distance(point))
        {
        }

        public void SetGraphics(Graphics graph)
        {
            this.graph = graph;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        public void Draw()
        {
            graph.DrawEllipse(pen, corner.x, corner.y, width, height);
        }
    }
}
