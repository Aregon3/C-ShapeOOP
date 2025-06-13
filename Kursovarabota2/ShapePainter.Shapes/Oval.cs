using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stage_2.Shapes
{
    [Serializable]

    class Oval : Shape
    {
        public Oval(Point a, Point b) : base(a, b)
        {

        }


        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, X, Y, W, H);
            SolidBrush solidBrush = new SolidBrush(Color.LightGreen);
            g.FillEllipse(solidBrush, X, Y, W, H);
            if (IsSelected)
            {
                DrawSelection(g);
                SolidBrush solidBrush1 = new SolidBrush(Color.Green);
                g.FillEllipse(solidBrush1, X, Y, W, H);
            }
        }


    }
}
