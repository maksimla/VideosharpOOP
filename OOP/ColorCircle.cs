using System.Drawing;

namespace OOP
{
    class ColorCircle
    {

        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width;
        public int height;
        public Pen pen;

        public ColorCircle(int x, int y, int radius, Color color)
            : this(new Pixel(x, y), radius, color)
        {
        }

        public ColorCircle(Pixel center, int radius, Color color)
        {
            this.center = center;
            this.radius = radius;
            corner = new Pixel(center.x - radius, center.y - radius);
            width = height = radius * 2;
            pen = new Pen(color,2);
        }

        public ColorCircle(Pixel center, Pixel point, Color color)
            : this(center, center.distance(point), color)
        {
        }
    }
}
