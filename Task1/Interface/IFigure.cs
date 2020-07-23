using Task3.Enums;

namespace Task3.Interface
{
    interface IFigure
    {
        TypeFigure TypeFigure { get; set; }

        Color Color { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
