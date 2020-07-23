using System.Collections.Generic;

namespace Task3.Interface
{
    interface IPolygonFigure : IFigure
    {
        public List<double> Sides { get; set; }
    }
}
