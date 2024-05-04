using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    /******************************************************************************/
    public class Cuboid : Polygon, I2DShape, I3DShape
    {
        public Cuboid(double l, double h, double w)
        {
            Length = l;
            Height = h;
            Width = w;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * (Width * Length) + (Height * Length) + (Height * Width);
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }

        public double Volume()
        {
            return Length * Height * Width;
        }
    }
}