using ConsoleApp.ClassesDemo.Interfaces;

namespace ConsoleApp.ClassesDemo.Classes.ShapeDemo
{
    /******************************************************************************/
    public class Rectangle : Polygon , I2DShape {
        public Rectangle(double width, double lenght)
        {
            Width = width;
            Length = lenght;
        }
        public double Length { get; set; }

        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return (2 * Width) + (2 * Length);
        }

        public override string GetShapeName()
        {
            return base.GetShapeName();
        }
    }
}