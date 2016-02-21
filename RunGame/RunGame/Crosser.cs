using System;
using System.Drawing;

namespace RunGame
{
    class Crosser
    {
        public bool Cross(IPlayer o1, IPlayer o2)
        {
            if (o1.GetType() == typeof(Circle))
                return Cross((Circle)o1, o2);
            if (o1.GetType() == typeof(Box))
                return Cross((Box)o1, o2);
            return false;
        }

        public bool Cross(Circle circle, IPlayer o2)
        {
            if (o2.GetType() == typeof(Circle))
                return Cross(circle, (Circle)o2);
            if (o2.GetType() == typeof(Box))
                return Cross(circle, (Box)o2);
            return false;
        }


        public bool Cross(Box box, IPlayer o2)
        {
            if (o2.GetType() == typeof(Circle))
                return Cross((Circle)o2, box);
            if (o2.GetType() == typeof(Box))
                return Cross(box, (Box)o2);
            return false;
        }

        public bool Cross(Circle c1, Circle c2)
        {
            return distance(c1.Center, c2.Center) <= c1.Radius + c2.Radius;
        }

        public bool Cross(Circle circle, Box box)
        {
            Rectangle rectangle = new Rectangle(circle.Center.X - circle.Radius,
                                                circle.Center.Y - circle.Radius,
                                                circle.Center.X + circle.Radius,
                                                circle.Center.Y + circle.Radius);
            if (!Cross(box.Rectangle, rectangle))
                return false;

            return
                circle.Radius >= distance(circle.Center, new Point(box.Rectangle.Left, box.Rectangle.Top)) ||
                circle.Radius >= distance(circle.Center, new Point(box.Rectangle.Left, box.Rectangle.Bottom)) ||
                circle.Radius >= distance(circle.Center, new Point(box.Rectangle.Right, box.Rectangle.Top)) ||
                circle.Radius >= distance(circle.Center, new Point(box.Rectangle.Right, box.Rectangle.Bottom));

        }

        public bool Cross(Box box1, Box box2)
        {
            return Cross(box1.Rectangle, box2.Rectangle);
        }

        private int distance(Point p, Point q)
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(p.X - q.X, 2) + Math.Pow(p.Y - q.Y, 2)));
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
