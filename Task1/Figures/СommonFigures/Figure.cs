using Task3.Interface;

namespace Task3.Figure
{
    public abstract class Figure : IFigure
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString() => $"Perimeter: {GetPerimeter()}, area: {GetArea()}\n";
    }
}
