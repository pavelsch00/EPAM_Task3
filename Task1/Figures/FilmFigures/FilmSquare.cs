using System;
using System.Collections.Generic;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmSquare : Square, IFilm
    {
        public FilmSquare(IEnumerable<double> sides) : base(sides)
        {
        }

        public FilmSquare(FilmSquare filmSquare) : base(filmSquare.Sides)
        {
            if (GetArea() < filmSquare.GetArea())
                throw new ArgumentException("Can't create a new shape with a larger area", "Area");
        }

        public override bool Equals(object obj) => obj is FilmSquare square &&
           EqualityComparer<List<double>>.Default.Equals(Sides, square.Sides);

        public override int GetHashCode() => HashCode.Combine(Sides);

        public override string ToString() => $"Figure Type: {GetType().Name}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
