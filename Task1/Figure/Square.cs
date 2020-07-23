using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Figure
{
    class Square : Figure, IPolygonFigure
    {
        public Square(List<double> sides)
        {
            if ((sides.Count() != 1) && (sides.Count() != 4))
                throw new ArgumentException("Wrong number of sides. 1 or 4 sides allowed.", "sides");

            if (sides.Count() == 4 && (sides[0] != sides[1] || sides[1] != sides[2] || sides[2] != sides[3]))
                throw new ArgumentException("Unequal sides", "sides");

            Sides = sides.ToList();
        }

        public List<double> Sides { get; set; }

        public override double GetPerimeter() => Sides[0] * 4;

        public override double GetArea() => Sides[0] * Sides[0];

        public override bool Equals(object obj) => obj is Square square &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, square.Sides) && Color == square.Color;

        public override int GetHashCode() => HashCode.Combine(Sides);
    }
}
