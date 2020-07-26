using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Figure
{
    public abstract class Square : Figure, IPolygonFigure
    {
        public Square(IEnumerable<double> sides)
        {
            if ((sides.Count() != 1) && (sides.Count() != 4))
                throw new ArgumentException("Wrong number of sides. 1 or 4 sides allowed.", "sides");

            Sides = sides.ToList();
        }

        public List<double> Sides { get; }

        public override double GetPerimeter() => Sides[0] * 4;

        public override double GetArea() => Sides[0] * Sides[0];

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj) => obj is Square square &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, square.Sides);

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
