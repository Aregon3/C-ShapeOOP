using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Shapes
{
    public interface ISelectable
    {
       bool Contains(Point point);
       void DrawSelection(Graphics g);
    }
}
