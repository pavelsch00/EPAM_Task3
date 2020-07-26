using Figure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;

namespace XmlFileExtension
{
    public class GetFromFileUsingXmlReader
    {
        private const int _sizeArray = 20;

        private const string _paperMaterial = "Paper";

        private const string _circleFigure = "Circle";

        public static IFigure[] GetFromFile(string path)
        {
            var figures = new IFigure[_sizeArray];
            var sides = new List<double>();
            using var xmlReader = new XmlTextReader(path);
            object color = null;
            string material = null;
            string figureName = null;

            double radius = 0;
            int count = 0;

            string patternMaterial = @"(Paper|Film)([A-z]*)";
            string patternNumber = @"(\d+|\d.+)\<";

            var regex = new Regex(patternNumber);
            while (xmlReader.Read())
            {
                if (!Enum.TryParse(typeof(FigureType), xmlReader.Name, out object figureType))
                    continue;

                regex = new Regex(patternMaterial);
                foreach (Match match in regex.Matches(figureType.ToString()))
                {
                    material = match.Groups[1].Value;
                    figureName = match.Groups[2].Value;
                }

                xmlReader.Read();
                xmlReader.Read();

                if (figureName != _circleFigure)
                {
                    sides = new List<double>();

                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(IPolygonFigure.Sides)))
                        sides = xmlReader.ReadElementString().Split(' ').Select(obj => double.Parse(obj)).ToList();
                }
                else
                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(ICircle.Radius)))
                        radius = double.Parse(xmlReader.ReadElementString());

                if (material == _paperMaterial)
                {
                    xmlReader.Read();

                    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == nameof(IPaper.Color)))
                        color = Enum.Parse(typeof(Color), xmlReader.ReadElementString());
                }

                switch (figureType)
                {
                    case FigureType.PaperCircle:
                        figures[count] = new PaperCircle(radius, (Color)color);
                        break;

                    case FigureType.PaperRectangle:
                        figures[count] = new PaperRectangle(sides, (Color)color);
                        break;

                    case FigureType.PaperSquare:
                        figures[count] = new PaperSquare(sides, (Color)color);
                        break;

                    case FigureType.PaperTriangle:
                        figures[count] = new PaperTriangle(sides, (Color)color);
                        break;

                    case FigureType.FilmCircle:
                        figures[count] = new FilmCircle(radius);
                        break;

                    case FigureType.FilmRectangle:
                        figures[count] = new FilmRectangle(sides);
                        break;

                    case FigureType.FilmSquare:
                        figures[count] = new FilmSquare(sides);
                        break;

                    case FigureType.FilmTriangle:
                        figures[count] = new FilmTriangle(sides);
                        break;

                }
                count++;
                if (count == figures.Length - 1)
                    return figures;
                xmlReader.Read();
            }

            return figures;
        }
    }
}
