using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karacsony.Entities
{
    public class Present : Toy
    {
        public SolidBrush Ribbon { get; private set; }
        public SolidBrush Box { get; private set; }

        public Present(Color ribbon, Color box)
        {
            Ribbon = new SolidBrush(ribbon);
            Box = new SolidBrush(box);

        }
        protected override void DrawImage(Graphics g)
        {
            int ribbonWidth = 8;
            g.FillRectangle(Box, 0, 0, Width, Height);
            g.FillRectangle(Ribbon, 0, Height / 2 - ribbonWidth / 2, Width, ribbonWidth);
            g.FillRectangle(Ribbon, Width / 2 - ribbonWidth / 2, 0, ribbonWidth, Height);
        }
    }
}
