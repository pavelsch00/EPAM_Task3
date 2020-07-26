using System;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    public class PaperCircle : Circle, IPaper
    {
        public PaperCircle(double radius, Color color) : base(radius)
        {
            Color = color;
            IsСhangeColor = true;
        }

        public PaperCircle(PaperCircle paperCirlce) : base(paperCirlce.Radius)
        {
            if (Radius < paperCirlce.Radius)
                throw new ArgumentException("Can't create a new shape with a larger radius", "Radius");
        }

        public bool IsСhangeColor { get; set; }

        public Color Color { get; set; }

        public void СhangeСolor(Color color)
        {
            if (IsСhangeColor == false)
                throw new ArgumentException("Color can only be changed once.", "Color");

            Color = color;
            IsСhangeColor = false;
        }

        public override bool Equals(object obj) => obj is PaperCircle circle &&
                   Radius == circle.Radius && Color == circle.Color;

        public override int GetHashCode() => HashCode.Combine(Radius) * HashCode.Combine(Color);

        public override string ToString() => $"Figure Type: {GetType().Name}, Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
