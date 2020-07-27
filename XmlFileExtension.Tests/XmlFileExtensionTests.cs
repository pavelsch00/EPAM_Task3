using System;
using System.Collections.Generic;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;
using MyBox;
using Xunit;
using Task3.Enums;

namespace XmlFileExtension.Tests
{
    public class XmlFileExtensionTests
    {
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
    }
}
