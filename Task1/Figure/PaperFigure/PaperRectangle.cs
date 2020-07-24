using System;
using System.Collections.Generic;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    public class PaperRectangle : Rectangle, IPaper
    {
        public PaperRectangle(IEnumerable<double> sides, Color color) : base(sides)
        {
            Color = color;
            IsСhangeColor = true;
        }

        public PaperRectangle(PaperRectangle paperRectangle) : base(paperRectangle.Sides)
        {
            if (GetArea() < paperRectangle.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger area", "Area");
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

        public override bool Equals(object obj) => obj is PaperRectangle rectangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, rectangle.Sides) && Color == rectangle.Color;

        public override int GetHashCode() => HashCode.Combine(Sides) * HashCode.Combine(Color);

        public override string ToString() => $"Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
