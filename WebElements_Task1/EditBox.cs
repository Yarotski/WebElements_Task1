using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class EditBox:TextBox
    {
        public int MaxSize { get; set; }

        public EditBox(string type, float x, float y, float hgt, float w, int fz, string fn, int ms) : base(type, x, y, hgt, w, fz, fn)
        {
            MaxSize = ms;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + FontSize + " " + FontName + " " + MaxSize;
        }
    }
}
