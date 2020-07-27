using System;
using System.Collections.Generic;
using Task3.Interface;

namespace Task3.Figure
{
    /// <summary>
    /// Abstract class describes a circle.
    /// </summary>
    public abstract class Circle : Figure, ICircle
    {
        /// <summary>
        /// The constructor creates a circle object using a radius.
        /// </summary>
        /// <param name="radius">Cicle radius</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set;  }

        /// <inheritdoc cref="IFigure.GetPerimeter()"/>
        public override double GetPerimeter() => 2 * Radius * Math.PI;

        /// <inheritdoc cref="IFigure.GetArea()"/>
        public override double GetArea() => Math.Pow(Radius, 2) * Math.PI;

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
