﻿using System;
using System.Collections.Generic;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    /// <summary>
    /// Class describes a film square.
    /// </summary>
    public class FilmSquare : Square, IFilm
    {
        /// <summary>
        /// Constructor to create an object using sides.
        /// </summary>
        /// <param name="sides">sides</param>
        public FilmSquare(IEnumerable<double> sides) : base(sides)
        {
        }

        /// <summary>
        /// Constructor to create an object from a given.
        /// </summary>
        /// <param name="filmSquare">filmSquare</param>
        public FilmSquare(IFigure polygonFigure, List<double> sides) : base(sides)
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

            Square square = (Square)obj;

            for (int i = 0; i < Sides.Count; i++)
                if (Sides[i] != square.Sides[i])
                    return false;

            return true;
        }

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
