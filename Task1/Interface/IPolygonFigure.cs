using System.Collections.Generic;

namespace Task3.Interface
{
    interface IPolygonFigure : IFigure
    {
        List<double> Sides { get; set; }
    }
}
