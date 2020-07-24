using System;
using System.Collections.Generic;
using System.Text;
using Task3.Interface;

namespace Box.Interfaces
{
    interface IBox
    {
        public IFigure[] Figures { get; set; }

        public void AddFigure(IFigure figure);

        public IFigure ViewByNumber(int index);

        public IFigure GetByNumber(int index);

        public void ReplaceByNumber(int index, IFigure figure);
    }
}
