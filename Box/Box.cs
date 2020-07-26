using Box.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figure;
using Task3.Interface;
using XmlFileExtension;

namespace Box
{
    public class Box : IBox
    {
        private const int _figuresArraySize = 20;

        public Box()
        {
            Figures = new IFigure[_figuresArraySize];
        }

        public IFigure[] Figures { get; set; }

        public void AddFigure(IFigure figure)
        {
            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    Figures[Figures.Length] = figure;

                if (Figures[i].Equals(figure))
                    throw new ArgumentException("No two identical figures are allowed", "figure");
            }
        }

        public IFigure ShowByNumber(int index)
        {
            if(index < 0)
                throw new ArgumentNullException("Index cannot be less than zero", "index");

            if (Figures[index] == null)
                throw new ArgumentNullException("Element doesn't exist");
            else
                return Figures[index];
        }

        public IFigure GetByNumber(int index)
        {
            if (index < 0)
                throw new ArgumentNullException("Index cannot be less than zero", "index");

            var figure = Figures[index];

            for (var i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                if (i == index)
                    for (var j = i; j < Figures.Length - 1; j++)
                        Figures[j] = Figures[j + 1];
            }

            return figure;
        }

        public void ReplaceByNumber(int index, IFigure figure) => Figures[index] = figure;

        public IFigure FindBySample(IFigure figure)
        {
            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                if (Figures.Equals(figure))
                    return Figures[i];
            }

            return null;
        }

        public int ShowCountFigures()
        {
            for (int i = 0; i < _figuresArraySize; i++)
                if (Figures[i] == null)
                    return i;

            return 0;
        }

        public double GetTotalArea()
        {
            double totalArea = 0;

            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                totalArea += Figures[i].GetArea();
            }

            return totalArea;
        }

        public double GetTotalPerimeter()
        {
            double totalPerimeter = 0;

            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                totalPerimeter += Figures[i].GetArea();
            }

            return totalPerimeter;
        }

        public IEnumerable<IFigure> GetAllCircle()
        {
            var circles = new List<IFigure>();

            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                if (Figures[i] is Circle)
                    circles.Add(Figures[i]);
            }

            return circles;
        }

        public IEnumerable<IFigure> GetAllFilmFigures()
        {
            var filmFigures = new List<IFigure>();

            for (int i = 0; i < _figuresArraySize; i++)
            {
                if (Figures[i] == null)
                    break;

                if (Figures[i] is IFilm)
                    filmFigures.Add(Figures[i]);
            }

            return filmFigures;
        }

        public void SaveFiguresToXmlFileUsingStreamWriter(string path) => SaveToFileUsingStreamWriter.SaveToFile(path, Figures);

        public void SaveFiguresToXmlFileUsingXmlWriter(string path) => SaveToFileUsingXmlWriter.SaveToFile(path, Figures);

        public void GetFiguresFromXmlFileUsingStreamReader(string path) => Figures = GetFromFileUsingXmlReader.GetFromFile(path);

        public void GetFiguresFromXmlFileUsingXmlReader(string path) => Figures = GetFromFileUsingXmlReader.GetFromFile(path);

        /// <summary>
        /// The method compares two objects for equivalence.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj) => obj is Box box &&
                   EqualityComparer<IFigure[]>.Default.Equals(Figures, box.Figures);

        /// <summary>
        /// The method gets the hash code of the object.
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode() => HashCode.Combine(Figures);

        /// <summary>
        /// The method returns information about the object in string form.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Figures)
            {
                if (item == null)
                    break;

                sb.Append(item.ToString()).Append("\n");
            }
            return $"Figure Type: {GetType().Name} \nFigures: \n{sb}";
        }
    }
}
