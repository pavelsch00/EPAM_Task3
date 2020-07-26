using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Figure
{
    public abstract class Triangle : Figure, IPolygonFigure
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

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj) => obj is Triangle triangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, triangle.Sides);

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(Sides);

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => $"Figure Type: {GetType().Name}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
