namespace OOP
{
    class Circle
    {
        public int x, y;
        public int radius;
        public int x1, y1;
        public int width;
        public int height;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            x1 = x - radius;
            y1 = y - radius;
            width = height = radius * 2;
        }

        public Circle(Pixel center, int radius)
        {
            this.x = center.x;
            this.y = center.y;
            this.radius = radius;
            x1 = x - radius;
            y1 = y - radius;
            width = height = radius * 2;
        }
    }
}
