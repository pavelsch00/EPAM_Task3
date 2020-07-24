using System;
using System.Collections.Generic;
using System.Text;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    public class PapperTriangle : Triangle, IPaper
    {
        public PapperTriangle(IEnumerable<double> sides, Color color) : base(sides)
        {
            Color = color;
            IsСhangeColor = true;
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

        public override bool Equals(object obj) => obj is PapperTriangle triangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, triangle.Sides) && Color == triangle.Color;

        public override int GetHashCode() => HashCode.Combine(Sides) * HashCode.Combine(Color);
    }
}
