using Figure.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;

namespace XmlFileExtension
{
    public class GetFromFileUsingStreamReader
    {
        private const int _sizeArray = 20;

        private const string _paperMaterial = "Paper";

        private const string _circleFigure = "Circle";

        public static IFigure[] GetFromFile(string path)
        {
            var figures = new IFigure[_sizeArray];
            var sides = new List<double>();

            object color = null;
            string material = null;
            string figureName = null;
            string content = null;

            double radius = 0;
            int count = 0;

            string patternMaterial = @"(Paper|Film)([A-z]*)";
            string patternNumber = @"(\d+|\d.+)\<";
            string patternColor = @">([A-z]*)<";
            var regex = new Regex(patternMaterial);

            using (var streamReader = new StreamReader(path))
            {
                while ((content = streamReader.ReadLine()) != null)
                {
                    if (!Enum.TryParse(typeof(FigureType), content.Trim('<', '>', '/', '\t', ' '), out object figureType))
                        continue;

                    regex = new Regex(patternMaterial);
                    foreach (Match match in regex.Matches(figureType.ToString()))
                    {
                        material = match.Groups[1].Value;
                        figureName = match.Groups[2].Value;
                    }

                    content = streamReader.ReadLine();
                    regex = new Regex(patternNumber);

                    if (figureName != _circleFigure)
                        foreach (Match match in regex.Matches(content))
                            sides = match.Groups[1].Value.Split(' ').Select(obj => double.Parse(obj)).ToList();
                    else
                        foreach (Match match in regex.Matches(content))
                            double.TryParse(match.Groups[1].Value, out radius);

                    if (material == _paperMaterial)
                    {
                        content = streamReader.ReadLine();
                        regex = new Regex(patternColor);
                        foreach (Match match in regex.Matches(content))
                            color = Enum.Parse(typeof(Color), match.Groups[1].Value);
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
                        default:
                            break;
                    }
                    count++;
                    if (count == figures.Length - 1)
                        return figures;
                    content = streamReader.ReadLine();
                }
            }

            return figures;
        }
    }
}
