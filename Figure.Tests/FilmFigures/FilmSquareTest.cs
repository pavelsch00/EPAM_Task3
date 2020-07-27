using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests
{
    public class FilmSquareTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperRectangle = new FilmSquare(new List<double> { 12 });
            var actual = new FilmRectangle(new List<double> { 5, 12 });

            // act
            var expected = new FilmRectangle(paperRectangle, new List<double> { 5 , 12});

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 48;

            // act
            var expected = new FilmSquare(new List<double> { 12 });
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 144;

            // act
            var expected = new FilmSquare(new List<double> { 12 });
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new FilmSquare(new List<double> { 12 });

            // act
            var expected = new FilmSquare(new List<double> { 12 });
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
