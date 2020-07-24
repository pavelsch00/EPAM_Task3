using System;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmCirle : Circle, IFilm
    {
        public FilmCirle(double radius) : base(radius)
        {
            Radius = radius;
        }

        public FilmCirle(FilmCirle filmCirle) : base(filmCirle.Radius)
        {
            if(Radius < filmCirle.Radius)
                throw new ArgumentException("Can't create a new shape with a larger radius.", "Radius");
        }

        public override bool Equals(object obj) => obj is FilmCirle circle &&
                   Radius == circle.Radius;

        public override int GetHashCode() => HashCode.Combine(Radius);

        public override string ToString() => $"Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
