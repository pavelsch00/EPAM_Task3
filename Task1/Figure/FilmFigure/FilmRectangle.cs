﻿using System;
using System.Collections.Generic;
using System.Text;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmRectangle : Rectangle, IFilm
    {
        public FilmRectangle(IEnumerable<double> sides) : base(sides)
        {
        }

        public override bool Equals(object obj) => obj is FilmRectangle rectangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, rectangle.Sides);

        public override int GetHashCode() => HashCode.Combine(Sides);

        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}