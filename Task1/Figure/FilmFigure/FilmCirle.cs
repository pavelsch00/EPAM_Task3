using System;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmCirle : Circle, IFilm
    {
        public FilmCirle(double radius) : base(radius)
        {
        }

        public override bool Equals(object obj) => obj is FilmCirle circle &&
                   Radius == circle.Radius;

        public override int GetHashCode() => HashCode.Combine(Radius);

        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
