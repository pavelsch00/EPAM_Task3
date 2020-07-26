using System;
using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;
using XmlFileExtension.WorkWithFile;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\Figures.xml";


            IFigure[] figures = new IFigure[20];

            figures[0] = new PaperCircle(5, Color.Red);

            figures[1] = new FilmRectangle(new List<double> { 11, 18 });

            SaveToFileUsingXmlWriter.SaveToFile(filePath, figures);
        }
    }
}
