using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    abstract class Element
    {
        public string ElementType { get; set; }
        public float XCoordinate { get; set; }
        public float YCoordinate { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }

        public abstract string GetInfo();

        public Element (string type, float x, float y, float hgt, float w)
        {
            ElementType = type;
            XCoordinate = x;
            YCoordinate = y;
            Height = hgt;
            Width = w;
        }
    }
}
