using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class Menu:Element, IClickable, IChangeColorable
    {
        public string MenuBackgroundColor { get; set; }
        public string OpenMenuColor { get; set; }

        public Menu(string type, float x, float y, float hgt, float w, string bgcolor, string openmc) : base(type, x, y, hgt, w)
        {
            MenuBackgroundColor = bgcolor;
            OpenMenuColor = openmc;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + MenuBackgroundColor + " " + OpenMenuColor;
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
