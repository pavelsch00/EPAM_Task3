﻿using System;
using Task3.Enums;

namespace Task3.Interface
{
    interface IPaper
    {
        bool IsСhangeColor { get; set; }

        Color Color { get; set; }

        public void СhangeСolor(Color color);
    }
}