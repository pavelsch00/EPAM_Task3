using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests
{
    public class PaperRectangleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperRectangle = new PaperRectangle(new List<double> { 12, 14 }, Color.Black);
            var actual = new PaperSquare(new List<double> { 5 }, Color.Black);

            // act
            var expected = new PaperSquare(paperRectangle, new List<double> { 5 }, paperRectangle.Color);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void —hange—olor_NewColor_—hange—olor()
        {
            var expected = new PaperRectangle(new List<double> { 12, 14 }, Color.Black);
            expected.—hange—olor(Color.Green);
            // act
            var actual = new PaperRectangle(new List<double> { 12, 14 }, Color.Green);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 52;
            
            // act
            var expected = new PaperRectangle(new List<double> { 12, 14 }, Color.Green);
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 168;

            // act
            var expected = new PaperRectangle(new List<double> { 12, 14 }, Color.Green);
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new PaperRectangle(new List<double> { 12, 14 }, Color.Green);

            // act
            var expected = new PaperRectangle(new List<double> { 12, 14 }, Color.Green);
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
