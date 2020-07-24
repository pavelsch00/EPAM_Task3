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

        public void СhangeСolor(Color color)
        {
            if (IsСhangeColor == false)
                throw new ArgumentException("Color can only be changed once.", "Color");

            Color = color;
            IsСhangeColor = false;
        }

        public bool IsСhangeColor { get; set; }

        public Color Color { get; set; }

        public override bool Equals(object obj) => obj is PaperCirlce circle &&
                   Radius == circle.Radius && Color == circle.Color;

        public override int GetHashCode() => HashCode.Combine(Radius) * HashCode.Combine(Color);

        public override string ToString() => $"Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
