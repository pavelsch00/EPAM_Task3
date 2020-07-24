using Box.Interfaces;
using System;
using Task3.Interface;

namespace Box
{
    public class Box : IBox
    {
        const int _figuresSize = 20;

        public Box()
        {
            Figures = new IFigure[_figuresSize];
        }

        public IFigure[] Figures { get; set; }

        public void AddFigure(IFigure figure)
        {
            for (int i = 0; i < Figures.Length; i++)
            {
                if (Figures[i].Equals(figure))
                    throw new ArgumentException("No two identical figures are allowed", "figure");
            }

            Figures[Figures.Length + 1] = figure;
        }

        public IFigure ViewByNumber(int index) => Figures[index];

        public IFigure GetByNumber(int index)
        {
            var figure = Figures[index];

            for (var i = 0; i < Figures.Length; i++)
                if (i == index)
                    for (var j = i; j < Figures.Length - 1; j++)
                        Figures[j] = Figures[j + 1];

            return figure;
        }

        public void ReplaceByNumber(int index, IFigure figure) => Figures[index] = figure;
    }
}
