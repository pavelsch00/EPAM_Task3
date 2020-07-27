using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.PaperFigure;
using Xunit;

namespace Figure.Tests.PaperFigures
{
    public class PaperTriangleTest
    {
        [Fact]
        public void CreateNewFigire_NewAreaLessOldArea_CreateNewFigire()
        {
            var paperTriangle = new PaperTriangle(new List<double> { 12, 14, 15 }, Color.Black);
            var actual = new PaperSquare(new List<double> { 5 }, Color.Black);

            // act
            var expected = new PaperSquare(paperTriangle, new List<double> { 5 }, paperTriangle.Color);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void СhangeСolor_NewColor_СhangeСolor()
        {
            var expected = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Black);
            expected.СhangeСolor(Color.Green);
            // act
            var actual = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Green);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPerimeter_NewRectangle_GetPerimeter()
        {
            var actual = 11;

            // act
            var expected = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Black);
            // assert;
            Assert.Equal(expected.GetPerimeter(), actual);
        }

        [Fact]
        public void GetArea_NewRectangle_GetArea()
        {
            var actual = 3.799671038392666;

            // act
            var expected = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Black);
            // assert;
            Assert.Equal(expected.GetArea(), actual);
        }

        [Fact]
        public void Equals_TwoRectangle_Equals()
        {
            var actual = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Black);

            // act
            var expected = new PaperTriangle(new List<double> { 2, 4, 5 }, Color.Black);
            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
