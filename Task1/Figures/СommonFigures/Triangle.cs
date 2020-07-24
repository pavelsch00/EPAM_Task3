using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Figure
{
    public class Triangle : Figure, IPolygonFigure
    {
        public Triangle(IEnumerable<double> sides)
        {
            if (sides.Count() != 3)
                throw new ArgumentException("Wrong number of sides. 3 sides allowed.", "sides");

            Sides = sides.ToList();
        }

        public List<double> Sides { get; }

        public override double GetPerimeter() => Sides[0] + Sides[1] + Sides[2];

        public override double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));
        }
    }
}
