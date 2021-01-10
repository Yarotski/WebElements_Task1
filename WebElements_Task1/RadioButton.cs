using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class RadioButton:Element, ISelectable
    {
        public bool IsSelectedByDefault { get; set; }
 
        public RadioButton(string type, float x, float y, float hgt, float w, bool selected) : base(type, x, y, hgt, w)
        {
            IsSelectedByDefault = selected;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + IsSelectedByDefault;
        }

        public void SelectElement(string selectedElement)
        {
            Console.WriteLine(selectedElement);
        }
    }
}
