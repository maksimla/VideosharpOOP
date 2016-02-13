using System.Collections.Generic;

namespace OOP
{
    class Sprite : Shape
    {
        List<Shape> shapes;

        public Sprite()
        {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shape.SetGraphics(graph);
            shapes.Add(shape);
        }

        public void Clear()
        {
            shapes.Clear();
        }

        public override void Draw()
        {
           shapes.ForEach(shape=>shape.Draw());
        }
    }
}
