using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BusWithGarmoshka.Program;

namespace BusWithGarmoshka
{
	public partial class FormBusConfig : Form
	{
		Vehicle bus = null;

		private event Action<Vehicle> eventAddBus;

		public FormBusConfig()
		{
			InitializeComponent();
			panelGoldColor.MouseDown += panelColor_MouseDown;
			panelRedColor.MouseDown += panelColor_MouseDown;
			panelOrangeRedColor.MouseDown += panelColor_MouseDown;
			panelRoyalBlueColor.MouseDown += panelColor_MouseDown;
			panelSeaGreenColor.MouseDown += panelColor_MouseDown;
			panelSlateBlueColor.MouseDown += panelColor_MouseDown;
			panelSpringGreenColor.MouseDown += panelColor_MouseDown;
			panelVioletColor.MouseDown += panelColor_MouseDown;


			buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawBus()
		{
			if (bus != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxFutureBus.Width, pictureBoxFutureBus.Height);
				Graphics gr = Graphics.FromImage(bmp);
				bus.SetPosition(5, 5, pictureBoxFutureBus.Width, pictureBoxFutureBus.Height);
				bus.DrawTransport(gr);
				pictureBoxFutureBus.Image = bmp;
			}
		}

		public void AddEvent(Action<Vehicle> ev)
		{
			if (eventAddBus == null)
			{
				eventAddBus = new Action<Vehicle>(ev);
			}
			else
			{
				eventAddBus += ev;
			}
		}

		private void labelNormalBus_MouseDown(object sender, MouseEventArgs e)
		{
			labelNormalBus.DoDragDrop(labelNormalBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void labelBusWithGarmoshka_MouseDown(object sender, MouseEventArgs e)
		{
			labelBusWithGarmoshka.DoDragDrop(labelBusWithGarmoshka.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void panelDrop_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelDrop_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Обычный автобус":
					bus = new Bus((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
					break;
				case "Автобус с гармошкой":
					bus = new BusWithGarmoshka((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxBackDoors.Checked, checkBoxGarmoshka.Checked);
					break;
			}
			DrawBus();
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			// Прописать логику вызова dragDrop для панелей, используя sender
			if (sender is Panel p)
			{
				p.DoDragDrop(p.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
			}
		}

		private void labelMainColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
			// Прописать логику проверки приходящего значения на тип Color
		}

		private void labelMainColor_DragDrop(object sender, DragEventArgs e)
		{
			bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
			DrawBus();
		}

		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{

			if (bus is BusWithGarmoshka b)
			{
				b.SetDopColor((Color)e.Data.GetData(typeof(Color)));
				DrawBus();
			}
			// Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			eventAddBus?.Invoke(bus);
			Close();
		}
	}
}
