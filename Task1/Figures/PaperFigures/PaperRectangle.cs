using System;
using System.Collections.Generic;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    /// <summary>
    /// Class describes a paper rectangle.
    /// </summary>
    public class PaperRectangle : Rectangle, IPaper
    {
        /// <summary>
        /// Constructor to create an object using sides and color.
        /// </summary>
        /// <param name="sides">sides</param>
        /// <param name="color">color</param>
        public PaperRectangle(IEnumerable<double> sides, Color color) : base(sides)
        {
            Color = color;
            IsСhangeColor = true;
        }

        /// <summary>
        /// Constructor to create an object from a given.
        /// </summary>
        /// <param name="paperRectangle">paperRectangle</param>
        public PaperRectangle(IFigure polygonFigure, List<double> sides, Color color) : base(sides)
        {
            if (GetArea() > polygonFigure.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger area", "Area");

            Color = color;
        }


        /// <inheritdoc cref="IPaper.IsСhangeColor)"/>
        public bool IsСhangeColor { get; set; }

        /// <inheritdoc cref="IPaper.Color)"/>
        public Color Color { get; set; }

        /// <inheritdoc cref="IPaper.СhangeСolor(Color))"/>
        public void СhangeСolor(Color color)
        {
            if (IsСhangeColor == false)
                throw new ArgumentException("Color can only be changed once.", "Color");

            Color = color;
            IsСhangeColor = false;
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

            PaperRectangle rectangle = (PaperRectangle)obj;

            return (base.Equals(obj) && (Color == rectangle.Color));
        }

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(Sides) * HashCode.Combine(Color);

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => $"Figure Type: {GetType().Name}, Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
