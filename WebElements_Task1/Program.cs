using System;
using System.Collections.Generic;

namespace WebElements_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox textBox1 = new TextBox("Text Box", 6, 22, 9, 25, 8, "Arial Black");
            EditBox editBox1 = new EditBox("Edit Box", 6.5f, 1.9f, 9, 25, 8, "Times", 200);
            RadioButton radioButton1 = new RadioButton("Radio Button", 1.9f, 0.8f, 4, 4, false);
            CheckBox checkBox1 = new CheckBox("Check Box", 2, 12.6f, 4, 4, true);
            Button button1 = new Button("Button", "Save", 66, 12, 8, 26);
            Link link1 = new Link("Link", 108, 0.8f, 4, 60, "Blue", "Red");
            Picture picture1 = new Picture("Picture", 108, 0.8f, 4, 60, 300);
            Menu menu1 = new Menu("Menu", 108, 0.8f, 4, 60, "Green", "Yellow");

            //Element[] elements = new Element[] { textBox1, editBox1, radioButton1, checkBox1, button1, link1, picture1, menu1 };

            List<Element> elements = new List<Element>();
            elements.Add(textBox1);
            elements.Add(editBox1);
            elements.Add(radioButton1);
            elements.Add(checkBox1);
            elements.Add(button1);
            elements.Add(link1);
            elements.Add(picture1);
            elements.Add(menu1);

            Console.WriteLine("All elements:");
            
            foreach (Element elementtype in elements)
            {
                Console.WriteLine(elementtype.GetInfo());
            }

            Console.WriteLine("\n" + "Selectable elements:");

            foreach (Element elementtype in elements)
            {
                if (elementtype is ISelectable)
                {
                    ISelectable selectElement = (ISelectable)elementtype;
                    selectElement.SelectElement();
                }
            }

            Console.WriteLine("\n" + "Clickable elements:");

            foreach (Element elementtype in elements)
            {
                if (elementtype is IClickable)
                {
                    IClickable clickElement = (IClickable)elementtype;
                    clickElement.ClickElement("I am " + "'" + elementtype.ElementType + "'" + " and you can click me");
                }
            }

            Console.WriteLine("\n" + "Change colorable elements:");

            foreach (Element elementtype in elements)
            {
                if (elementtype is IChangeColorable)
                {
                    IChangeColorable changecolorElement = (IChangeColorable)elementtype;
                    changecolorElement.ChangeColor("I am " + "'" + elementtype.ElementType + "'" + " and you can change my color");
                }
            }

        }
    }
}
