using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class Box : IPlayer
    {
        public Rectangle box { get; private set; }
        public Color Color { get; private set; }
        private int _sx;
        private int _sy;

        public Box(int x, int y, int w, int h)
            : this(x, y, w, h, 0, 0)
        {
        }

        public Box(int x, int y, int w, int h, int sx, int sy)
        {
            box = new Rectangle(x, y, w, h);
            Color = Color.Green;
            _sx = sx;
            _sy = sy;
        }

        public void Run()
        {
            Move();
        }

        private void Move()
        {
            int x = box.X + _sx;
            int y = box.Y + _sy;
            if (x < 0 || x > Arena.Range.Width - box.Width)
                _sx = -_sx;
            if (y < 0 || y > Arena.Range.Height - box.Height)
                _sy = -_sy;
            box = new Rectangle(box.X + _sx, box.Y + _sy, box.Width, box.Height);
        }

        public void Gole()
        {
            Color = Color.Red;
        }

        public void NoGole()
        {
            Color = Color.Green;
        }

        public bool IsCatch(IPlayer that)
        {
            if (that.GetType() != typeof(Box))
                return false;
            return Cross(box, ((Box)that).box);
            // return Rectangle.Intersect(box, ((Box)that).box) != Rectangle.Empty;
        }

        private bool Cross(Rectangle box1, Rectangle box2)
        {
            return (box1.Left <= box2.Right &&
                    box1.Right >= box2.Left &&
                    box1.Bottom >= box2.Top &&
                    box1.Top <= box2.Bottom);
        }
    }
}
