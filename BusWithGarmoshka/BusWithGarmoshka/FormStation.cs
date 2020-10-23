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
    public partial class FormStation : Form
    {
        private readonly Station<ITransport> station;
        public FormStation()
        {
            InitializeComponent();
            station = new Station<ITransport>(pictureBoxStation.Width, pictureBoxStation.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxStation.Width, pictureBoxStation.Height);
            Graphics gr = Graphics.FromImage(bmp);
            station.Draw(gr);
            pictureBoxStation.Image = bmp;
        }

        private void buttonParkBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(100, 1000, dialog.Color);
                if (station + bus)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Автовокзал переполнен");
                }
            }
        }

        private void buttonParkBusWithGarmoshka_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new BusWithGarmoshka(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (station + bus)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Автовокзал переполнен");
                    }
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxForBus.Text != "")
            {
                var bus = station - Convert.ToInt32(maskedTextBoxForBus.Text);
                if (bus != null)
                {
                    FormBusWithGarmoshka form = new FormBusWithGarmoshka();
                    form.SetBus(bus);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
