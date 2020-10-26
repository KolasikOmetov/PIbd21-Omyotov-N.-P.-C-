using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class Station<T> where T : class, ITransport
    {
        private readonly List<T> _places;
        private readonly int _maxCount;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int rows;
        private readonly int _placeSizeWidth = 350;
        private readonly int _placeSizeHeight = 80;

        public Station(int picWidth, int picHeight)
        {
            int columns = picWidth / _placeSizeWidth;
            rows = picHeight / _placeSizeHeight;
            _maxCount = columns * rows;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Station<T> p, T bus)
        {
            if (p._places.Count >= p._maxCount) {
                return false; 
            }

            p._places.Add(bus);

            return true;
        }

        public static T operator -(Station<T> p, int index)
        {
            if (index < -1 || index >= p._places.Count) { 
                return null; 
            }

            T bus = p._places[index];

            p._places.RemoveAt(index);

            return bus;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                _places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 15, pictureWidth, pictureHeight); _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }

                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
