namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    public abstract class Polygon {
        public double Width { get; set; }
        public abstract double Area();
        public virtual string GetShapeName() {
            throw new NotImplementedException();
        }
    }
}