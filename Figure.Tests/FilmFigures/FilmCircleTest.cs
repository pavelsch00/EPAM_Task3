using System.Collections.Generic;
using Task3.Figure.FilmFigure;
using Xunit;

namespace Figure.Tests.PaperFigures
{
    public class FilmCircleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var filmCircle = new FilmCircle(13);
            var actual = new FilmSquare(new List<double> { 5 });

            // act
            var expected = new FilmSquare(filmCircle, new List<double> { 5 });

            // assert;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 75.39822368615503;

            // act
            var expected = new FilmCircle(12);
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 452.3893421169302;

            // act
            var expected = new FilmCircle(12);
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new FilmCircle(12);

            // act
            var expected = new FilmCircle(12);
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
