using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Task3.Figure;
using Task3.Interface;

namespace XmlFileExtension.WorkWithFile
{
    class GetFromFileUsingXmlReader
    {
        public static IFigure[] GetToFile(string path)
        {
            var figures = new IFigure[20];

            using var xmlReader = new XmlTextReader(path);

            xmlReader.Read();

            return figures;
        }
    }
}
