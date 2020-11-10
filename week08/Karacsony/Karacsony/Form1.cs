using Karacsony.Abstractions;
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
        List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set
            {
                _factory = value;
                DisplayNext();
            }
        }
        private Toy _nextToy;


        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _toys.Add(ball);
            ball.Left = 0 - ball.Width;
            mainPanel.Controls.Add(ball);

        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var position = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > position)
                {
                    position = toy.Left;
                }
                if (position > 1000)
                {
                    var first = _toys[0];
                    mainPanel.Controls.Remove(first);
                    _toys.Remove(first);
                }
            }

        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();

        }

        private void ballBtn_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory()
            {
                BallColor = ballColor.BackColor
            };
        }

        private void DisplayNext()
        {

            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);

        }

        private void ballColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();
            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }

        private void presentBtn_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory()
            {
                Ribbon = presentRibbon.BackColor,
                Box = presentBox.BackColor
            };
        }
    }
}
