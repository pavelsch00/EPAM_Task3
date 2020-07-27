using System;
using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;
using Xunit;

namespace Box.Tests
{
    public class BoxTests
    {
        [Fact]
        public void AddFigure_FigureIsInBox_AddNewFigure()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            figures[2] = new PaperCircle(3, Color.Green);
            figures[3] = new PaperSquare(new List<double> { 5 }, Color.Green);
            var figure = new FilmCircle(6);
            var actualResult = new Box(figures);
            actualResult.AddFigure(figure);
            var expected = new Box(figures);

            // act
            expected.AddFigure(figure);

            // assert;
            Assert.Equal(expected, actualResult);
        }

        [Fact]
        public void AddFigure_BoxIsClear_AddNewFigure()
        {
            // arrange
            var figures = new IFigure[20];
            var figure = new FilmCircle(6);
            var actualResult = new Box(figures);
            actualResult.AddFigure(figure);
            var expected = new Box(figures);

            // act
            expected.AddFigure(figure);

            // assert;
            Assert.Equal(expected, actualResult);
        }

        [Fact]
        public void ShowByNumber_FigureIsInBox_ShowFigure()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new FilmRectangle(new List<double> { 4, 6 });
            figures[1] = new FilmTriangle(new List<double> { 3, 4, 5 });
            figures[2] = new FilmCircle(3);
            figures[3] = new FilmSquare(new List<double> { 5 });
            var actualResult = figures[1];
            var expectedBox = new Box(figures);

            // act
            var expected = expectedBox.ShowByNumber(1);

            // assert;
            Assert.Equal(expected, actualResult);
        }

        [Fact]
        public void GetByNumber_FigureIsInBox_GetByNumberAndRemoveInBox()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            figures[2] = new PaperCircle(3, Color.Green);
            figures[3] = new PaperSquare(new List<double> { 5 }, Color.Green);

            var actualResult = 3;
            var expectedBox = new Box(figures);

            // act
            expectedBox.GetByNumber(3);

            // assert;
            Assert.Equal(expectedBox.ShowCountFigures(), actualResult);
        }

        [Fact]
        public void ReplaceByNumber_FigureIsInBox_ReplaceByNumberFigure()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            var expectedBox = new Box(figures);

            var actualFigures = new IFigure[20];
            actualFigures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            actualFigures[1] = new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple);
            var actual = new Box(actualFigures);

            // act
            expectedBox.ReplaceByNumber(1, new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple));

            // assert;
            Assert.Equal(expectedBox, actual);
        }

        [Fact]
        public void FindBySample_FigureIsInBox_FindBySample()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple);
            var expectedBox = new Box(figures);

            IFigure actual = new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple);

            // act
            var expected = expectedBox.FindBySample(new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple));

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindBySample_FigureIsNotInBox_NotBySample()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 14, 8, 9 }, Color.Green);
            var expectedBox = new Box(figures);

            var actual = new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple);

            // act
            var expected = expectedBox.FindBySample(new PaperTriangle(new List<double> { 3, 8, 5 }, Color.Purple));

            // assert;
            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void GetTotalArea_FigureIsInBox_GetTotalArea()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 10, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 2, 3, 4 }, Color.Green);
            var actual = 62.90473750965556;
            var expectedBox = new Box(figures);

            // act
            var expected = expectedBox.GetTotalArea();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTotalPerimeter_FigureIsInBox_GetTotalPerimeter()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 10, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 2, 3, 4 }, Color.Green);
            var actual = 265;
            var expectedBox = new Box(figures);

            // act
            var expected = expectedBox.GetTotalPerimeter();

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetAllCircle_FigureIsInBox_GetAllCircle()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            figures[2] = new PaperCircle(3, Color.Green);
            figures[3] = new PaperSquare(new List<double> { 5 }, Color.Green);
            figures[4] = new FilmCircle(6);

            var actualFigures = new List<IFigure>();
            actualFigures.Add(new PaperCircle(3, Color.Green));
            actualFigures.Add(new FilmCircle(6));

            var expected = new Box(figures);

            // assert;
            Assert.Equal(expected.GetAllCircle(), actualFigures);
        }

        [Fact]
        public void GetFilmFIgure_FigureIsInBox_GetFilmFIgure()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            figures[2] = new FilmRectangle(new List<double> { 4, 6 });
            figures[3] = new FilmTriangle(new List<double> { 3, 4, 5 });
            figures[4] = new PaperCircle(3, Color.Green);
            figures[5] = new FilmSquare(new List<double> { 5 });
            figures[6] = new FilmCircle(6);

            var actualFigures = new List<IFigure>();
            actualFigures.Add(new FilmRectangle(new List<double> { 4, 6 }));
            actualFigures.Add(new FilmTriangle(new List<double> { 3, 4, 5 }));
            actualFigures.Add(new FilmSquare(new List<double> { 5 }));
            actualFigures.Add(new FilmCircle(6));
            var expected = new Box(figures);

            // assert;
            Assert.Equal(expected.GetAllFilmFigures(), actualFigures);
        }

        [Fact]
        public void SaveFiguresToXmlFileUsingStreamWriterAndGetFiguresFromXmlFileUsingStreamReader_FigureIsInBox_GetFigure()
        {
            // arrange
            string path = @"..\..\..\Figures.xml";
            var figures = new IFigure[20];
            figures[0] = new PaperCircle(5, Color.Red);
            figures[1] = new FilmRectangle(new List<double> { 11, 18 });
            figures[2] = new PaperSquare(new List<double> { 8 }, Color.Green);
            figures[3] = new FilmTriangle(new List<double> { 9, 11, 4 });

            var actualBox = new Box(figures);
            actualBox.SaveFiguresToXmlFileUsingStreamWriter(path);

            var expected = new Box();
            expected.GetFiguresFromXmlFileUsingStreamReader(path);
            // assert;
            Assert.Equal(expected, actualBox);
        }

        [Fact]
        public void SaveFiguresToXmlFileUsingXmlWriterAndGetFiguresFromXmlFileUsingXmlReader_FigureIsInBox_GetFIgure()
        {
            // arrange
            string path = @"..\..\..\Figures.xml";
            var figures = new IFigure[20];
            figures[0] = new PaperCircle(5, Color.Red);
            figures[1] = new FilmRectangle(new List<double> { 11, 18 });
            figures[2] = new PaperSquare(new List<double> { 8 }, Color.Green);
            figures[3] = new FilmTriangle(new List<double> { 9, 11, 4 });

            var actualBox = new Box(figures);
            actualBox.SaveFiguresToXmlFileUsingXmlWriter(path);

            var expected = new Box();
            expected.GetFiguresFromXmlFileUsingXmlReader(path);
            // assert;
            Assert.Equal(expected, actualBox);
        }

        [Fact]
        public void Equals_FigureIsInBox_Equals()
        {
            // arrange
            var figures = new IFigure[20];
            figures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            figures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            var expectedBox = new Box(figures);
            bool expected = true;
            var actualFigures = new IFigure[20];
            actualFigures[0] = new PaperRectangle(new List<double> { 4, 6 }, Color.Black);
            actualFigures[1] = new PaperTriangle(new List<double> { 3, 4, 5 }, Color.Red);
            var actual = new Box(actualFigures);

            // assert;
            Assert.Equal(expected, actual.Equals(expectedBox));
        }
    }
}
