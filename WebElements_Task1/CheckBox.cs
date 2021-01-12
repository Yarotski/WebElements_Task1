﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebElements_Task1
{
    class CheckBox:Element, ISelectable
    {
        public bool IsSelectedByDefault { get; set; }

        public CheckBox(string type, float x, float y, float hgt, float w, bool selected) : base(type, x, y, hgt, w)
        {
            IsSelectedByDefault = selected;
        }

        public override string GetInfo()
        {
            return ElementType + " " + XCoordinate + " " + YCoordinate + " " + Height + " " + Width + " " + IsSelectedByDefault;
        }

        public void SelectElement()
        {
            Console.WriteLine("I am CheckBox and you can select me!!");
        }
    }
}
