using System;
using System.Collections.Generic;
using System.Text;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmSquare : Square, IFilm
    {
        public FilmSquare(IEnumerable<double> sides) : base(sides)
        {
        }

        public override bool Equals(object obj) => obj is FilmSquare square &&
           EqualityComparer<List<double>>.Default.Equals(Sides, square.Sides);

        public override int GetHashCode() => HashCode.Combine(Sides);

        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
