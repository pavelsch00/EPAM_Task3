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

            figures[2] = new PaperSquare(new List<double> { 8 }, Color.Green);

            figures[3] = new FilmTriangle(new List<double> { 9, 11, 4 });

            SaveToFileUsingXmlWriter.SaveToFile(filePath, figures);

            figures = GetFromFileUsingXmlReader.GetToFile(filePath);

            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] == null)
                    break;

                Console.WriteLine(figures[i].ToString());
            }
        }
    }
}
