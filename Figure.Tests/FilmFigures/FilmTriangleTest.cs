using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests.PaperFigures
{
    public class FilmTriangleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperTriangle = new FilmTriangle(new List<double> { 12, 14, 15 });
            var actual = new FilmSquare(new List<double> { 5 });

            // act
            var expected = new FilmSquare(paperTriangle, new List<double> { 5 });

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 11;

            // act
            var expected = new FilmTriangle(new List<double> { 2, 4, 5 });
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 3.799671038392666;

            // act
            var expected = new FilmTriangle(new List<double> { 2, 4, 5 });
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new FilmTriangle(new List<double> { 2, 4, 5 });

            // act
            var expected = new FilmTriangle(new List<double> { 2, 4, 5 });
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
