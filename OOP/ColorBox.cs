﻿using System;
using System.Drawing;

namespace OOP
{
    class ColorBox : Box
    {
        public Pen pen;

        public ColorBox(int x1, int y1, int x2, int y2, Color color)
           : this(new Pixel(x1, y1), new Pixel(x2, y2), color)
        {
        }

        public ColorBox(Pixel lu, Pixel rd, Color color)
            : base(lu, rd)
        {
            pen = new Pen(color, 2);
        }

        public override void Draw(Graphics graph, Pen pen)
        {
            base.Draw(graph, this.pen);
        }
    }
}
