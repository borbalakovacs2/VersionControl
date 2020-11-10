using Karacsony.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karacsony
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();
        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _balls.Add(ball);
            ball.Left = 0 - ball.Width;
            mainPanel.Controls.Add(ball);

        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var position = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > position)
                {
                    position = ball.Left;
                }
                if (position > 1000)
                {
                    var first = _balls[0];
                    mainPanel.Controls.Remove(first);
                    _balls.Remove(first);

                }
            }

        }
    }
}
