using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BusWithGarmoshka
{
    public partial class FormStation : Form
    {
        private readonly StationCollection stationCollection;

        private readonly Logger logger;

        public FormStation()
        {
            InitializeComponent();
            stationCollection = new StationCollection(pictureBoxStation.Width, pictureBoxStation.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили автовокзал {textBoxNameOfStation.Text}");
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
                try
                {
                    if (stationCollection[listBoxOfStations.SelectedItem.ToString()] + bus)
                    {
                        Draw();
                        logger.Info($"Добавлен автобус {bus}");
                    }
                    else
                    {
                        MessageBox.Show("Автобус не удалось поставить");
                    }
                    Draw();
                }
                catch (StationOverflowException ex)
                {
                    logger.Warn("Переполнение: " + ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка: " + ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelStation_Click(object sender, EventArgs e)
        {
            if (listBoxOfStations.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить автовокзал {listBoxOfStations.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили автовокзал {listBoxOfStations.SelectedItem}");
                    stationCollection.DelStation(listBoxOfStations.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxOfStations.SelectedIndex > -1 && maskedTextBoxForBus.Text != "")
            {
                try
                {
                    var bus = stationCollection[listBoxOfStations.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxForBus.Text);
                    if (bus != null)
                    {
                        FormBusWithGarmoshka form = new FormBusWithGarmoshka();
                        form.SetBus(bus);
                        form.ShowDialog();
                        logger.Info($"Изъят автобус {bus} с места {maskedTextBoxForBus.Text}");
                        Draw();
                    }
                }
                catch (StationNotFoundException ex)
                {
                    logger.Warn("Не найдено: " + ex.Message);
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении: " + ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxOfStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку {listBoxOfStations.SelectedItem}");
            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogBus.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stationCollection.SaveData(saveFileDialogBus.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogBus.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении: " + ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogBus.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stationCollection.LoadData(openFileDialogBus.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogBus.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении: " + ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (listBoxOfStations.SelectedIndex > -1)
            {
                stationCollection[listBoxOfStations.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }
    }
}
