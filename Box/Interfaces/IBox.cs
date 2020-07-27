using System.Collections.Generic;
using Task3.Interface;

namespace MyBox.Interfaces
{
    /// <summary>
    /// The interface describes the Box class.
    /// </summary>
    interface IBox
    {

        /// <summary>
        /// The property stores figures.
        /// </summary>
        public IFigure[] Figures { get; set; }

        /// <summary>
        /// The method adds a figure to an array of figures.
        /// </summary>
        /// <param name="figure">figure</param>
        public void AddFigure(IFigure figure);

        /// <summary>
        /// The method shows the figure by index.
        /// </summary>
        /// <param name="index">index</param>
        public IFigure ShowByNumber(int index);

        /// <summary>
        /// The method get a figure out of the box by number.
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>IFigure</returns>
        public IFigure GetByNumber(int index);

        /// <summary>
        /// Meteod will replace the figure by number.
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="figure">index</param>
        public void ReplaceByNumber(int index, IFigure figure);

        /// <summary>
        /// The method find for an equivalent figure in an array.
        /// </summary>
        /// <param name="figure">figure</param>
        /// <returns>IFigure</returns>
        public IFigure FindBySample(IFigure figure);

        /// <summary>
        /// The method shows the number of figures in the box.
        /// </summary>
        /// <returns>int</returns>
        public int ShowCountFigures();

        /// <summary>
        /// The method gets the total area of the figures.
        /// </summary>
        /// <returns>double</returns>
        public double GetTotalArea();

        /// <summary>
        /// The method gets the total perimeter of the figures.
        /// </summary>
        /// <returns>double</returns>
        public double GetTotalPerimeter();

        /// <summary>
        /// The method gets all the circles out of the box.
        /// </summary>
        /// <returns>IEnumerable<IFigure></returns>
        public IEnumerable<IFigure> GetAllCircle();

        /// <summary>
        /// The method gets all the film figures out of the box.
        /// </summary>
        /// <returns>IEnumerable<IFigure></returns>
        public IEnumerable<IFigure> GetAllFilmFigures();

        /// <summary>
        /// Method saves all figures to xml file using StreamWriter.
        /// </summary>
        /// <param name="path">path</param>
        public void SaveFiguresToXmlFileUsingStreamWriter(string path);

        /// <summary>
        /// Method saves all figures to xml file using XmlWriter.
        /// </summary>
        /// <param name="path">path</param>
        public void SaveFiguresToXmlFileUsingXmlWriter(string path);

        /// <summary>
        /// Method get all figures from xml file using StreamReader.
        /// </summary>
        /// <param name="path">path</param>
        public void GetFiguresFromXmlFileUsingStreamReader(string path);

        /// <summary>
        /// Method get all figures from xml file using XmlReader.
        /// </summary>
        /// <param name="path">path</param>
        public void GetFiguresFromXmlFileUsingXmlReader(string path);

    }
}
