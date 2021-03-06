﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karacsony.Entities
{
    public class Ball : Toy
        
    {
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics g) 
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);

        }
    }
}
