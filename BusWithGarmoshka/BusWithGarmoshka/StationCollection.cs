using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class StationCollection
    {
        readonly Dictionary<string, Station<Vehicle>> stationStages;

        public List<string> Keys => stationStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public StationCollection(int pictureWidth, int pictureHeight)
        {
            stationStages = new Dictionary<string, Station<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddStation(string name)
        {
            if (stationStages.Keys.Contains(name)) { return; }

            stationStages.Add(name, new Station<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelStation(string name)
        {
            if (stationStages.ContainsKey(name))
            {
                stationStages.Remove(name);
            }
        }

        public Station<Vehicle> this[string ind]
        {

            get
            {
                if (!stationStages.ContainsKey(ind))
                {
                    return null;
                }
                return stationStages[ind];
            }

        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"StationCollection");
                foreach (var level in stationStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Station{separator}{level.Key}");
                    ITransport bus = null;
                    for (int i = 0; (bus = level.Value.GetNext(i)) != null; i++)
                    {
                        if (bus != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (bus.GetType().Name == "Bus")
                            {
                                sw.Write($"Bus{separator}");
                            }
                            if (bus.GetType().Name == "BusWithGarmoshka")
                            {
                                sw.Write($"BusWithGarmoshka{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(bus);
                        }
                    }

                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                bool head = true;
                string line;
                Vehicle bus = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("\r", "");
                    if (head)
                    {
                        if (line.Contains("StationCollection"))
                        {
                            //очищаем записи
                            stationStages.Clear();
                            head = false;
                        }
                        else
                        {
                            //если нет такой записи, то это не те данные
                            return false;
                        }
                    }
                    else
                    {
                        //идем по считанным записям
                        if (line.Contains("Station"))
                        {//начинаем новую парковку
                            key = line.Split(separator)[1];
                            stationStages.Add(key, new Station<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Bus")
                        {
                            bus = new Bus(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "BusWithGarmoshka")
                        {
                            bus = new BusWithGarmoshka(line.Split(separator)[1]);
                        }
                        var result = stationStages[key] + bus;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
