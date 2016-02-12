using System.Drawing;

namespace OOP
{
    internal class ColorLine : Line
    {
        public Pen pen;

        public ColorLine(int x1, int y1, int x2, int y2, Color color)
            : this(new Pixel(x1, y1), new Pixel(x2, y2), color)
        {
        }

        public ColorLine(Pixel begin, Pixel ended, Color color)
            : base(begin, ended)
        {
            pen = new Pen(color, 2);
        }

        public override void Draw(Graphics graph, Pen pen)
        {
            graph.DrawLine(this.pen, begin.x, begin.y, ended.x, ended.y);
        }
    }
}