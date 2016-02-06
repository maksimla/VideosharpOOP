namespace OOP
{
    class Box
    {
        public int x1, y1;
        public int x2, y2;
        public int width, height;

        public Box(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            width = x2 - x1;
            height = y2 - y1;
        }

        public Box(Pixel lu, Pixel rd)
        {
            x1 = lu.x;
            y1 = lu.y;
            x2 = rd.x;
            y2 = rd.y;
            width = x2 - x1;
            height = y2 - y1;
        }
    }
}
