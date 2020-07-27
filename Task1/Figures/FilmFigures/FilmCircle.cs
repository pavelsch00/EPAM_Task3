using System;
using System.Collections.Generic;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    /// <summary>
    /// Class describes a film circle.
    /// </summary>
    public class FilmCircle : Circle, IFilm
    {
        /// <summary>
        /// Constructor to create an object using radius.
        /// </summary>
        /// <param name="radius">radius</param>
        public FilmCircle(double radius) : base(radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Constructor to create an object from a given.
        /// </summary>
        /// <param name="filmCirle">filmCirle</param>
        public FilmCircle(IFigure polygonFigure, List<double> sides) : base(sides[0])
        {
            if (GetArea() > polygonFigure.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger radius", "Radius");
        }

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            Circle circle = (Circle)obj;

            if (Radius != circle.Radius)
                return false;

            return true;
        }

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(Radius);

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => $"Figure Type: {GetType().Name}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
