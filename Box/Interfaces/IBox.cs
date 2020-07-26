﻿using System.Collections.Generic;
using Task3.Interface;

namespace Box.Interfaces
{
    interface IBox
    {
        public IFigure[] Figures { get; set; }

        public void AddFigure(IFigure figure);

        public IFigure ShowByNumber(int index);

        public IFigure GetByNumber(int index);

        public void ReplaceByNumber(int index, IFigure figure);

        public IFigure FindBySample(IFigure figure);

        public int ShowCountFigures();

        public double GetTotalArea();

        public double GetTotalPerimeter();

        public IEnumerable<IFigure> GetAllCircle();

        public IEnumerable<IFigure> GetAllFilmFigures();

        public void SaveFiguresToXmlFileUsingStreamWriter(string path);

        public void SaveFiguresToXmlFileUsingXmlWriter(string path);

        public void GetFiguresFromXmlFileUsingStreamReader(string path);

        public void GetFiguresFromXmlFileUsingXmlReader(string path);

    }
}
