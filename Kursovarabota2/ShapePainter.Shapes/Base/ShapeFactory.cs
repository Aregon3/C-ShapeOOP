using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;


namespace Stage_2.Shapes
{
    public class ShapeFactory
    {
        public static Shape Create(string type, Point a, Point b)
        {
            switch (type)
            {
                case "Rect":     return new Rect(a, b);
                case "Oval":     return new Oval(a, b);
                case "Triangle": return new Triangle(a, b);
                default:         return null;
            }
        }
    }
}
