using System;
using System.Collections.Generic;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmRectangle : Rectangle, IFilm
    {
        public FilmRectangle(IEnumerable<double> sides) : base(sides)
        {
        }

        public FilmRectangle(FilmRectangle filmRectangle) : base(filmRectangle.Sides)
        {
            if (GetArea() < filmRectangle.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger area", "Area");
        }

        public override bool Equals(object obj) => obj is FilmRectangle rectangle &&
                   EqualityComparer<List<double>>.Default.Equals(Sides, rectangle.Sides);

        public override int GetHashCode() => HashCode.Combine(Sides);

        public override string ToString() => $"Figure Type: {GetType().Name}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
