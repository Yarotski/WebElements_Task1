using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class Link:Element, IClickable, IChangeColorable
    {
        public string ActiveLinkColor { get; set; }
        public string VisitedLinkColor { get; set; }

        public Link(string type, float x, float y, float hgt, float w, string activelc, string visitedlc) : base(type, x, y, hgt, w)
        {
            ActiveLinkColor = activelc;
            VisitedLinkColor = visitedlc;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + ActiveLinkColor + " " + VisitedLinkColor;
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
