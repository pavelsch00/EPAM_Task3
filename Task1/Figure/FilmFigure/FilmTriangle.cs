using System;
using System.Collections.Generic;
using System.Text;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmTriangle : Triangle, IFilm
    {
        public FilmTriangle(IEnumerable<double> sides) : base(sides)
        {
        }

        public FilmTriangle(FilmTriangle filmTriangle) : base(filmTriangle.Sides)
        {
            if (GetArea() < filmTriangle.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger area", "Area");
        }

        public override bool Equals(object obj) => obj is FilmTriangle triangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, triangle.Sides);

        public override int GetHashCode() => HashCode.Combine(Sides);

        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
