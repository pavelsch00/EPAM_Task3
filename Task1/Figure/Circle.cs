using System;
using System.Collections.Generic;
using System.Text;
using Task3.Interface;

namespace Task3.Figure
{
    public class Circle : Figure, ICIrcle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double GetPerimeter() => 2 * Radius * Math.PI;

        public override double GetArea() => Math.Pow(Radius, 2) * Math.PI;

        public override bool Equals(object obj) => obj is Circle circle &&
                   Radius == circle.Radius && Color == circle.Color;

        public override int GetHashCode() => HashCode.Combine(Radius) * HashCode.Combine(Color);
    }
}
