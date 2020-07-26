using Figure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;

namespace XmlFileExtension.WorkWithFile
{
    public class GetFromFileUsingXmlReader
    {
        public static IFigure[] GetToFile(string path)
        {
            var figures = new IFigure[20];
            var sides = new List<double>();
            using var xmlReader = new XmlTextReader(path);
            object color = null;
            double radius = 0;
            int count = 0;

            while (xmlReader.Read())
            {
                if (!Enum.TryParse(typeof(FigureType), xmlReader.Name, out object figureType))
                    continue;
                switch (figureType)
                {
                    case FigureType.PaperCircle:

                        xmlReader.Read();
                        xmlReader.Read();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperCircle.Radius)))
                            radius = double.Parse(xmlReader.ReadElementString());

                        xmlReader.Read();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperCircle.Color)))
                            color = Enum.Parse(typeof(Color), xmlReader.ReadElementString());

                        figures[count] = new PaperCircle(radius, (Color)color);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.PaperRectangle:

                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperRectangle.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        xmlReader.Read();
                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperRectangle.Color)))
                            color = Enum.Parse(typeof(Color), xmlReader.ReadElementString());

                        figures[count] = new PaperRectangle(sides, (Color)color);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.PaperSquare:
                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperSquare.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        xmlReader.Read();
                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperSquare.Color)))
                            color = Enum.Parse(typeof(Color), xmlReader.ReadElementString());

                        figures[count] = new PaperSquare(sides, (Color)color);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.PaperTriangle:
                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperTriangle.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        xmlReader.Read();
                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(PaperTriangle.Color)))
                            color = Enum.Parse(typeof(Color), xmlReader.ReadElementString());

                        figures[count] = new PaperTriangle(sides, (Color)color);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.FilmCircle:

                        xmlReader.Read();
                        xmlReader.Read();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(FilmCircle.Radius)))
                            radius = double.Parse(xmlReader.ReadElementString());

                        figures[count] = new FilmCircle(radius);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.FilmRectangle:
                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(FilmRectangle.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        figures[count] = new FilmRectangle(sides);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.FilmSquare:
                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(FilmSquare.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        figures[count] = new FilmSquare(sides);
                        count++;
                        xmlReader.Read();
                        break;

                    case FigureType.FilmTriangle:
                        xmlReader.Read();
                        xmlReader.Read();

                        sides = new List<double>();

                        if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(FilmTriangle.Sides)))
                            sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();

                        figures[count] = new FilmTriangle(sides);
                        count++;
                        xmlReader.Read();
                        break;

                }
                if (count == figures.Length - 1)
                    return figures;
            }
            return figures;
        }
    }
}
