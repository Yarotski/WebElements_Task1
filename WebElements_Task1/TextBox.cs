using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class TextBox:Element, IChangeColorable
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public TextBox(string type, float x, float y, float hgt, float w, int fz, string fn) : base(type, x, y, hgt, w)
        {
            FontSize = fz;
            FontName = fn;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + FontSize + " " + FontName;
        }
        public void ChangeColor(string changedColorElement)
        {
            Console.WriteLine(changedColorElement);
        }
    }
}
