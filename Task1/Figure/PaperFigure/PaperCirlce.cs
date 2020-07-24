using System;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    public class PaperCirlce : Circle, IPaper
    {
        public PaperCirlce(double radius, Color color) : base(radius)
        {
            Color = color;
            IsСhangeColor = true;
        }

        public PaperCirlce(PaperCirlce paperCirlce) : base(paperCirlce.Radius)
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

        public override bool Equals(object obj) => obj is PaperCirlce circle &&
                   Radius == circle.Radius && Color == circle.Color;

        public override int GetHashCode() => HashCode.Combine(Radius) * HashCode.Combine(Color);

        public override string ToString() => $"Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
