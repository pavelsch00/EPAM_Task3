using Figure.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Task3.Enums;
using Task3.Figure.FilmFigure;
using Task3.Figure.PaperFigure;
using Task3.Interface;

namespace XmlFileExtension.WorkWithFile
{
    public class GetFromXmlFileUsingStreamReader
    {
        public static IFigure[] GetToFile(string path)
        {
            var figures = new IFigure[20];
            var sides = new List<double>();

            object color = null;
            string material = null;
            string figureName = null;

            double radius = 0;
            int count = 0;

            string patternMaterial = @"(Paper|Film)([A-z]*)";
            string pattern = @"(\d+|\d.+)\<";
            string patternColor = @">([A-z]*)<";
            var regex = new Regex(pattern);

            using (var streamReader = new StreamReader(path))
            {
                string content = null;

                while ((content = streamReader.ReadLine()) != null)
                {
                    string elementContent = content.Trim('<', '>', '/', '\t', ' ');

                    if (!Enum.TryParse(typeof(FigureType), elementContent, out object figureType))
                        continue;

                    regex = new Regex(patternMaterial);
                    foreach (Match match in regex.Matches(figureType.ToString()))
                    {
                        material = match.Groups[1].Value;
                        figureName = match.Groups[2].Value;
                    }

                    if (figureName != "Circle")
                    {
                        content = streamReader.ReadLine();
                        sides = new List<double>();

                        regex = new Regex(pattern);
                        foreach (Match match in regex.Matches(content))
                            sides = match.Groups[1].Value.Split(' ').Select(obj => double.Parse(obj)).ToList();

                        if(material == "Paper")
                        {
                            content = streamReader.ReadLine();

                            regex = new Regex(patternColor);
                            foreach (Match match in regex.Matches(content))
                                color = Enum.Parse(typeof(Color), match.Groups[1].Value);
                        }
                    }else 
                    {
                        content = streamReader.ReadLine();

                        regex = new Regex(pattern);
                        foreach (Match match in regex.Matches(content))
                            double.TryParse(match.Groups[1].Value, out radius);

                        content = streamReader.ReadLine();

                        if (material == "Paper")
                        {
                            regex = new Regex(patternColor);
                            foreach (Match match in regex.Matches(content))
                                color = Enum.Parse(typeof(Color), match.Groups[1].Value);
                        }
                    }

                    switch (figureType)
                    {
                        case FigureType.PaperCircle:
                            figures[count] = new PaperCircle(radius, (Color)color);
                            count++;
                            break;

                        case FigureType.PaperRectangle:
                            figures[count] = new PaperRectangle(sides, (Color)color);
                            count++;
                            break;

                        case FigureType.PaperSquare:
                            figures[count] = new PaperSquare(sides, (Color)color);
                            count++;
                            break;

                        case FigureType.PaperTriangle:
                            figures[count] = new PaperTriangle(sides, (Color)color);
                            count++;
                            break;

                        case FigureType.FilmCircle:
                            figures[count] = new FilmCircle(radius);
                            count++;
                            break;

                        case FigureType.FilmRectangle:
                            figures[count] = new FilmRectangle(sides);
                            count++;
                            break;

                        case FigureType.FilmSquare:
                            figures[count] = new FilmSquare(sides);
                            count++;
                            break;

                        case FigureType.FilmTriangle:
                            figures[count] = new FilmTriangle(sides);
                            count++;
                            break;
                        default:
                            break;
                    }
                    if (count == figures.Length - 1)
                        return figures;
                    content = streamReader.ReadLine();
                }
            }
            return figures;
        }
    }
}
