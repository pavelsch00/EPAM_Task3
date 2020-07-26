using System.Collections.Generic;

namespace Task3.Interface
{
    /// <summary>
    /// The interface stores information about the sides of the polygon.
    /// </summary>
    public interface IPolygonFigure : IFigure
    {
        /// <summary>
        /// The property stores information about the sides of the polygon.
        /// </summary>
        List<double> Sides { get; }
    }
}
