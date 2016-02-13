namespace OOP
{
    class Line : Shape
    {
        public Pixel begin;
        public Pixel ended;

        public Line(int x1, int y1, int x2, int y2)
            : this(new Pixel(x1, y1), new Pixel(x2, y2))
        {
        }

        public Line(Pixel begin, Pixel ended)
        {
            this.begin = begin;
            this.ended = ended;
        }

        public override void Draw()
        {
            graph.DrawLine(pen, begin.x+position.x, begin.y+position.y, 
                                ended.x+position.x, ended.y+position.y);
        }
    }
}
