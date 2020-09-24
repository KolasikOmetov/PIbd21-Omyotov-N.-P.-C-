using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusWithGarmoshka
{
    public partial class FormBusWithGarmoshka : Form
    {
        private BusWithGarmoshka bus;

        public FormBusWithGarmoshka()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBuses.Width, pictureBoxBuses.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus.DrawTransport(gr);
            pictureBoxBuses.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new BusWithGarmoshka(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBuses.Width, pictureBoxBuses.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    bus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    bus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    bus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
