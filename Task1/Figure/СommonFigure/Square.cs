using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Figure
{
    public class Square : Figure, IPolygonFigure
    {
        public Square(IEnumerable<double> sides)
        {
            if ((sides.Count() != 1) && (sides.Count() != 4))
                throw new ArgumentException("Wrong number of sides. 1 or 4 sides allowed.", "sides");

            Sides = sides.ToList();
        }

        public List<double> Sides { get; set; }

        public override double GetPerimeter() => Sides[0] * 4;

        public override double GetArea() => Sides[0] * Sides[0];
    }
}
