using System;
using System.Drawing;

namespace OOP
{
    class ColorBox
    {
        public Pixel corner1;
        public Pixel corner2;
        public int width, height;
        public Pen pen;

        public ColorBox(int x1, int y1, int x2, int y2, Color color)
           : this(new Pixel(x1, y1), new Pixel(x2, y2),color)
        {
        }

        public ColorBox(Pixel lu, Pixel rd, Color color)
        {
            corner1 = lu;
            corner2 = rd;
            width = Math.Abs(corner2.x - corner1.x);
            height = Math.Abs(corner2.y - corner1.y);
            pen=new Pen(color,2);
        }
    }
}
