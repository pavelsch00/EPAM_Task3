using System.Collections.Generic;

namespace Task3.Interface
{
    public interface IPolygonFigure : IFigure
    {
        List<double> Sides { get; }
    }
}
