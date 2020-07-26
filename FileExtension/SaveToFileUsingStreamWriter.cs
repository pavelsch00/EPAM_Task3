using System.IO;
using System.Text;
using Task3.Figure;
using Task3.Interface;

namespace XmlFileExtension
{
    /// <summary>
    /// Class save figures to a xml file using StreamWriter.
    /// </summary>
    public class SaveToFileUsingStreamWriter
    {
        /// <summary>
        /// Method save figures to a xml file using StreamWriter.
        /// </summary>
        /// <param name="path">path</param>
        /// <param name="figures">figures</param>
        public static void SaveToFile(string path, IFigure[] figures)
        {
            using var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");

            streamWriter.WriteLine("<Figures>");

            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] == null)
                    break;

                streamWriter.WriteLine($"  <{figures[i].GetType().Name}>");

                if (figures[i] is Circle)
                    streamWriter.WriteLine($"\t<Radius>{(figures[i] as Circle).Radius.ToString()}</Radius>");
                else
                {
                    var sb = new StringBuilder();

                    for (int j = 0; j < (figures[i] as IPolygonFigure).Sides.Count; j++)
                    {
                        sb.Append((figures[i] as IPolygonFigure).Sides[j]);

                        if (j != (figures[i] as IPolygonFigure).Sides.Count - 1)
                            sb.Append(" ");
                    }

                    streamWriter.WriteLine($"\t<Sides>{sb.ToString()}</Sides>");
                }

                if (figures[i] is IPaper)
                    streamWriter.WriteLine($"\t<Color>{(figures[i] as IPaper).Color.ToString()}</Color>");

                streamWriter.WriteLine($"  </{figures[i].GetType().Name}>");
            }

            streamWriter.WriteLine("</Figures>");
            streamWriter.Close();
        }
        }
    }
