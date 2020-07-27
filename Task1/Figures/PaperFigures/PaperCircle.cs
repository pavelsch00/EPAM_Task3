using System;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure.PaperFigure
{
    /// <summary>
    /// Class describes a paper circle.
    /// </summary>
    public class PaperCircle : Circle, IPaper
    {
        /// <summary>
        /// Constructor to create an object using radius and color.
        /// </summary>
        /// <param name="radius">radius</param>
        /// <param name="color">color</param>
        public PaperCircle(double radius, Color color) : base(radius)
        {
            Color = color;
            IsСhangeColor = true;
        }

        /// <summary>
        /// Constructor to create an object from a given.
        /// </summary>
        /// <param name="paperCirlce">paperCirlce</param>
        public PaperCircle(PaperCircle paperCirlce) : base(paperCirlce.Radius)
        {
            if (Radius < paperCirlce.Radius)
                throw new ArgumentException("Can't create a new shape with a larger radius", "Radius");
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

            PaperCircle circle = (PaperCircle)obj;

            return ((Color == circle.Color) && base.Equals(obj));
        }

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(Radius) * HashCode.Combine(Color);

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString() => $"Figure Type: {GetType().Name}, Color: {Color}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
