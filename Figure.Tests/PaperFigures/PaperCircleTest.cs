using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests.PaperFigures
{
    public class PaperCircleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperCircle = new PaperCircle(13, Color.Black);
            var actual = new PaperSquare(new List<double> { 5 }, Color.Black);

            // act
            var expected = new PaperSquare(paperCircle, new List<double> { 5 }, paperCircle.Color);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void СhangeСolor_NewColor_СhangeСolor()
        {
            var expected = new PaperCircle(12, Color.Black);
            expected.СhangeСolor(Color.Green);
            // act
            var actual = new PaperCircle(12, Color.Green);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 75.39822368615503;

            // act
            var expected = new PaperCircle(12, Color.Green);
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 452.3893421169302;

            // act
            var expected = new PaperCircle(12, Color.Green);
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new PaperCircle(12, Color.Green);

            // act
            var expected = new PaperCircle(12, Color.Green);
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
