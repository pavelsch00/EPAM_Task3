using System;
using System.Collections.Generic;
using System.Text;
using Task3.Enums;
using Task3.Interface;

namespace Task3.Figure
{
    public abstract class Figure : IFigure
    {
        public TypeFigure TypeFigure { get; set; }

        public Color Color { get; set; }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Color: {Color}, perimeter: {GetPerimeter()}, area: {GetArea()}\n";
        }
    }
}
