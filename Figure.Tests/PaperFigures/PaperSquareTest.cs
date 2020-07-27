using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests
{
    public class PaperSquareTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperRectangle = new PaperSquare(new List<double> { 12 }, Color.Black);
            var actual = new PaperRectangle(new List<double> { 5, 12 }, Color.Black);

            // act
            var expected = new PaperRectangle(paperRectangle, new List<double> { 5 , 12}, paperRectangle.Color);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void СhangeСolor_NewColor_СhangeСolor()
        {
            var expected = new PaperSquare(new List<double> { 12 }, Color.Black);
            expected.СhangeСolor(Color.Green);
            // act
            var actual = new PaperSquare(new List<double> { 12 }, Color.Green);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 48;

            // act
            var expected = new PaperSquare(new List<double> { 12 }, Color.Black);
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 144;

            // act
            var expected = new PaperSquare(new List<double> { 12 }, Color.Black);
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new PaperSquare(new List<double> { 12 }, Color.Green);

            // act
            var expected = new PaperSquare(new List<double> { 12 }, Color.Green);
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
