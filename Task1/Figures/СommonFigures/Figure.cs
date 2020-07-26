using System;
using Task3.Interface;

namespace Task3.Figure
{
    public abstract class Figure : IFigure
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj) => obj is Figure figure && GetArea() == figure.GetArea() && GetPerimeter() == figure.GetPerimeter();

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(GetArea() * GetPerimeter());

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
