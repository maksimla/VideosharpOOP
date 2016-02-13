using System.Drawing;

namespace OOP
{
    public abstract class Shape
    {
        protected Pixel position;
        protected Graphics graph;
        protected Pen pen;

        public Shape()
        {
            pen = new Pen(Color.Black);
        }

        public void SetGraphics(Graphics graph)
        {
            this.graph = graph;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        public abstract void Draw();
    }
}
