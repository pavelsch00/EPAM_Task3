using System;
using System.Collections.Generic;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;
using XmlFileExtension;
using Box;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\Figures.xml";
            Box.Box box = new Box.Box();
            IFigure[] arr = new IFigure[20];
            box.GetFiguresFromXmlFileUsingXmlReader(filePath);
            Console.WriteLine(box.ToString());
        }
    }
}
