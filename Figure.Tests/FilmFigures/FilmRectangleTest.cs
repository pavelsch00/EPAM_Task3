using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests
{
    public class FilmRectangleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var filmRectangle = new FilmRectangle(new List<double> { 12, 14 });
            var actual = new FilmSquare(new List<double> { 5 });

            // act
            var expected = new FilmSquare(filmRectangle, new List<double> { 5 });

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 52;
            
            // act
            var expected = new FilmRectangle(new List<double> { 12, 14 });
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 168;

            // act
            var expected = new FilmRectangle(new List<double> { 12, 14 });
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new FilmRectangle(new List<double> { 12, 14 });

            // act
            var expected = new FilmRectangle(new List<double> { 12, 14 });
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
