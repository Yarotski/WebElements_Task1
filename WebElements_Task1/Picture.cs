using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class Picture:Element, IChangeColorable
    {
        public int Resolution { get; set; }
        
        public Picture(string type, float x, float y, float hgt, float w, int res) : base(type, x, y, hgt, w)
        {
            Resolution = res;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + Resolution + "DPI";
        }

        public void ChangeColor(string changedColorElement)
        {
            Console.WriteLine(changedColorElement);
        }
    }
}
