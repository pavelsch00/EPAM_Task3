using System;
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
        public FilmCircle(FilmCircle filmCirle) : base(filmCirle.Radius)
        {
            if(Radius < filmCirle.Radius)
                throw new ArgumentException("Can't create a new shape with a larger radius.", "Radius");
        }

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj) => obj is FilmCircle circle &&
                   Radius == circle.Radius;

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
