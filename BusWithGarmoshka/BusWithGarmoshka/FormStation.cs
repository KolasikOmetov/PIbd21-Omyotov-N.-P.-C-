﻿using System;
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
		private readonly StationCollection stationCollection;

		public FormStation()
		{
			InitializeComponent();
			stationCollection = new StationCollection(pictureBoxStation.Width, pictureBoxStation.Height);
			Draw();
		}

		private void ReloadLevels()
		{
			int index = listBoxOfStations.SelectedIndex;

			listBoxOfStations.Items.Clear();
			for (int i = 0; i < stationCollection.Keys.Count; i++)
			{
				listBoxOfStations.Items.Add(stationCollection.Keys[i]);
			}

			if (listBoxOfStations.Items.Count > 0 && (index == -1 || index >= listBoxOfStations.Items.Count))
			{
				listBoxOfStations.SelectedIndex = 0;
			}
			else if (listBoxOfStations.Items.Count > 0 && index > -1 && index < listBoxOfStations.Items.Count)
			{
				listBoxOfStations.SelectedIndex = index;
			}
		}

		private void Draw()
		{
			if (listBoxOfStations.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxStation.Width, pictureBoxStation.Height);
				Graphics gr = Graphics.FromImage(bmp);
				stationCollection[listBoxOfStations.SelectedItem.ToString()].Draw(gr);
				pictureBoxStation.Image = bmp;
			}
		}

		private void buttonAddStation_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNameOfStation.Text))
			{
				MessageBox.Show("Введите название автовокзала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
			}
			stationCollection.AddStation(textBoxNameOfStation.Text);
			ReloadLevels();
		}

		private void buttonAddBus_Click(object sender, EventArgs e)
		{
			var formCarConfig = new FormBusConfig();
			formCarConfig.AddEvent(AddBus);
			formCarConfig.Show();
		}

		private void AddBus(Vehicle bus)
		{
			if (bus != null && listBoxOfStations.SelectedIndex > -1)
			{
				if ((stationCollection[listBoxOfStations.SelectedItem.ToString()]) + bus)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Автобус не удалось поставить");
				}
			}
		}

		private void buttonDelStation_Click(object sender, EventArgs e)
		{
			if (listBoxOfStations.SelectedIndex > -1)
			{
				if (MessageBox.Show($"Удалить автовокзал {listBoxOfStations.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					stationCollection.DelStation(listBoxOfStations.SelectedItem.ToString());
					ReloadLevels();
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (listBoxOfStations.SelectedIndex > -1)
			{
				if (maskedTextBoxForBus.Text != "")
				{
					var bus = stationCollection[listBoxOfStations.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxForBus.Text);
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
		private void listBoxOfStations_SelectedIndexChanged(object sender, EventArgs e)
		{
			Draw();
		}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialogBus.ShowDialog() == DialogResult.OK)
			{
				if (stationCollection.SaveData(saveFileDialogBus.FileName))
				{
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialogBus.ShowDialog() == DialogResult.OK)
			{
				if (stationCollection.LoadData(openFileDialogBus.FileName))
				{
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ReloadLevels();
					Draw();
				}
				else
				{
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
    }
}
