using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class Button:Element, IClickable, IChangeColorable
    {
        public string ButtonName { get; set; }

        public Button(string type, string btname, float x, float y, float hgt, float w) : base(type, x, y, hgt, w)
        {
            ButtonName = btname;
        }

        public override string GetInfo()
        {
            return ElementType + " " + ButtonName + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width;
        }

        public void ClickElement(string clickedElement)
        {
            Console.WriteLine(clickedElement);
        }

        public void ChangeColor(string changedColorElement)
        {
            Console.WriteLine(changedColorElement);
        }
    }
}
