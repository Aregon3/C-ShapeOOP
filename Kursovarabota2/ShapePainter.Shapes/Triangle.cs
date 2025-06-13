using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Stage_2.Shapes
{
    class Triangle : Shape
    {
        public Triangle(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y + H, X + W, Y + H);
            g.DrawLine(pen, X, Y + H, X + W / 2, Y);
            g.DrawLine(pen, X + W / 2, Y, X + W, Y + H);
            SolidBrush solidBrush = new SolidBrush(Color.Yellow);
            Point point1 = new Point((int)X, ((int)(Y + H)));
            Point point2 = new Point((int)(X + W), ((int)(Y + H)));
            Point point3 = new Point((int)(X + W / 2), ((int)(Y)));
            Point[] triPoints = { point1, point2, point3 };
            g.FillPolygon(solidBrush, triPoints);
            if (IsSelected)
            {
                DrawSelection(g);
                SolidBrush solidBrush2 = new SolidBrush(Color.DarkGoldenrod);
                g.FillPolygon(solidBrush2, triPoints);
            }

        }
    }
}
