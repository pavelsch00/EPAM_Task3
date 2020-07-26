using System;
using Task3.Interface;

namespace Task3.Figure.FilmFigure
{
    public class FilmCircle : Circle, IFilm
    {
        public FilmCircle(double radius) : base(radius)
        {
            Radius = radius;
        }

        public FilmCircle(FilmCircle filmCirle) : base(filmCirle.Radius)
        {
            if(Radius < filmCirle.Radius)
                throw new ArgumentException("Can't create a new shape with a larger radius.", "Radius");
        }

        public override bool Equals(object obj) => obj is FilmCircle circle &&
                   Radius == circle.Radius;

        public override int GetHashCode() => HashCode.Combine(Radius);

        public override string ToString() => $"Figure Type: {GetType().Name}, Perimeter: {GetPerimeter()}, Area: {GetArea()}\n";
    }
}
