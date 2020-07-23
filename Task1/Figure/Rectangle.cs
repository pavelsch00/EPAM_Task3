using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task3.Interface;

namespace Task3.Figure
{
    class Rectangle : Figure, IPolygonFigure
    {
        public Rectangle(List<double> sides)
        {
            if ((sides.Count() != 2) && (sides.Count() != 4))
                throw new ArgumentException("Wrong number of sides. 2 or 4 sides allowed.", "sides");

            Sides = sides.ToList();
        }

        public List<double> Sides { get; set; }

        public override double GetArea() => Sides[0] * Sides[1];

        public override double GetPerimeter() => (Sides[0] + Sides[1]) * 2;

        public override bool Equals(object obj) => obj is Rectangle rectangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, rectangle.Sides) && Color == rectangle.Color;

        public override int GetHashCode() => HashCode.Combine(Sides);
    }
}
