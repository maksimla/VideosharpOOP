using System.Drawing;

namespace OOP
{
    class ColorCircle : Circle
    {
        public Pen pen;

        public ColorCircle(int x, int y, int radius, Color color)
            : this(new Pixel(x, y), radius, color)
        {
        }

        public ColorCircle(Pixel center, int radius, Color color)
            : base(center, radius)
        {
            pen = new Pen(color, 2);
        }

        public ColorCircle(Pixel center, Pixel point, Color color)
            : this(center, center.distance(point), color)
        {
        }

        public override void Draw(Graphics graph, Pen pen)
        {
           base.Draw(graph,this.pen);
        }
    }
}
