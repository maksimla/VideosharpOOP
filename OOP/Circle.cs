﻿using System.Drawing;

namespace OOP
{
    class Circle : Shape
    {
        public Pixel center;
        public int radius;
        public Pixel corner;
        public int width;
        public int height;



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


        public override void Draw(Graphics graph, Pen pen)
        {
            graph.DrawEllipse(pen, corner.x, corner.y, width, height);
        }
    }
}
