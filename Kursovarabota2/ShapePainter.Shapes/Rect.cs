using System;
using System.Collections.Generic;
using System.Drawing;

namespace Stage_2.Shapes
{
    [Serializable]
    public class Rect : Shape
    {
        public Rect(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, W, H);
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            g.FillRectangle(solidBrush, X, Y, W, H);
            if (IsSelected)
            {
                DrawSelection(g);
                SolidBrush solidBrush3 = new SolidBrush(Color.DarkRed);
                g.FillRectangle(solidBrush3, X, Y, W, H);
            }
        }
    }
}
