using Box.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Task3.Figure;
using Task3.Interface;
using XmlFileExtension;

namespace Box
{
    /// <summary>
    /// Class describes a box with figures.
    /// </summary>
    public class Box : IBox
    {
        private const int _figuresArraySize = 20;

        /// <summary>
        /// The constructor creates a box.
        /// </summary>
        public Box()
        {
            Figures = new IFigure[_figuresArraySize];
        }

        /// <summary>
        /// The constructor creates a box using a figures.
        /// </summary>
        /// <param name="radius">figures</param>
        public Box(IFigure[] figures)
        {
            Figures = figures;
        }
        /// <inheritdoc cref="IBox.Figures"/>
        public IFigure[] Figures { get; set; }

        /// <inheritdoc cref="IBox.AddFigure"/>
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

        /// <inheritdoc cref="IBox.ShowByNumber"/>
        public IFigure ShowByNumber(int index)
        {
            if(index < 0)
                throw new ArgumentNullException("Index cannot be less than zero", "index");

            if (Figures[index] == null)
                throw new ArgumentNullException("Element doesn't exist");
            else
                return Figures[index];
        }

        /// <inheritdoc cref="IBox.GetByNumber"/>
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

        /// <inheritdoc cref="IBox.ReplaceByNumber"/>
        public void ReplaceByNumber(int index, IFigure figure) => Figures[index] = figure;

        /// <inheritdoc cref="IBox.FindBySample"/>
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

        /// <inheritdoc cref="IBox.ShowCountFigures"/>
        public int ShowCountFigures()
        {
            for (int i = 0; i < _figuresArraySize; i++)
                if (Figures[i] == null)
                    return i;

            return 0;
        }

        /// <inheritdoc cref="IBox.GetTotalArea"/>
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

        /// <inheritdoc cref="IBox.GetTotalPerimeter"/>
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

        /// <inheritdoc cref="IBox.GetAllCircle"/>
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

        /// <inheritdoc cref="IBox.GetAllFilmFigures"/>
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

        /// <inheritdoc cref="IBox.SaveFiguresToXmlFileUsingStreamWriter"/>
        public void SaveFiguresToXmlFileUsingStreamWriter(string path) => SaveToFileUsingStreamWriter.SaveToFile(path, Figures);

        /// <inheritdoc cref="IBox.SaveFiguresToXmlFileUsingXmlWriter"/>
        public void SaveFiguresToXmlFileUsingXmlWriter(string path) => SaveToFileUsingXmlWriter.SaveToFile(path, Figures);

        /// <inheritdoc cref="IBox.GetFiguresFromXmlFileUsingStreamReader"/>
        public void GetFiguresFromXmlFileUsingStreamReader(string path) => Figures = GetFromFileUsingXmlReader.GetFromFile(path);

        /// <inheritdoc cref="IBox.GetFiguresFromXmlFileUsingXmlReader"/>
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
