﻿using System;

namespace OOP
{
    class Box
    {
        public Pixel corner1;
        public Pixel corner2;
        public int width, height;

        public Box(int x1, int y1, int x2, int y2)
           : this(new Pixel(x1, y1), new Pixel(x2, y2))
        {
        }

        public Box(Pixel lu, Pixel rd)
        {
            corner1 = lu;
            corner2 = rd;
            width = Math.Abs(corner2.x - corner1.x);
            height = Math.Abs(corner2.y - corner1.y);
        }
    }
}
