using System.Drawing;

namespace OOP
{
    internal class ColorLine
    {
        public Pixel begin;
        public Pixel ended;
        public Pen pen;

        public ColorLine(int x1, int y1, int x2, int y2, Color color)
            : this(new Pixel(x1, y1), new Pixel(x2, y2), color)
        {
        }

        public ColorLine(Pixel begin, Pixel ended, Color color)
        {
            this.begin = begin;
            this.ended = ended;
            pen = new Pen(color,2);
        }
    }
}