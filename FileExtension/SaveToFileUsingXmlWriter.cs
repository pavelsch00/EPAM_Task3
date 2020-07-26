using System.Text;
using System.Xml;
using Task3.Interface;
using Task3.Figure;

namespace XmlFileExtension
{
    public class SaveToFileUsingXmlWriter
    {
        public static void SaveToFile(string path, IFigure[] figures)
        {
            using var xmlWriter = new XmlTextWriter(path, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Figures");

            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] == null)
                    break;

                xmlWriter.WriteStartElement(figures[i].GetType().Name);

                if(figures[i] is Circle)
                    xmlWriter.WriteElementString("Radius", (figures[i] as Circle).Radius.ToString());
                else
                {
                    var sb = new StringBuilder();

                    for (int j = 0; j < (figures[i] as IPolygonFigure).Sides.Count; j++)
                    {
                        sb.Append((figures[i] as IPolygonFigure).Sides[j]);

                        if (j != (figures[i] as IPolygonFigure).Sides.Count - 1)
                            sb.Append(" ");
                    }

                    xmlWriter.WriteElementString("Sides", sb.ToString());
                }

                if(figures[i] is IPaper)
                    xmlWriter.WriteElementString("Color", (figures[i] as IPaper).Color.ToString());

                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
