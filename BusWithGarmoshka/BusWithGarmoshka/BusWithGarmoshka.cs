using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class BusWithGarmoshka
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private readonly int carWidth = 320;
        private readonly int carHeight = 60;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool BackDoors { private set; get; }
        public bool Garmoshka { private set; get; }

        public BusWithGarmoshka(int maxSpeed, float weight, Color mainColor, Color dopColor, bool backDoors, bool garmoshka)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            BackDoors = backDoors;
            Garmoshka = garmoshka;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {

            Brush cusov = new SolidBrush(MainColor);
            g.FillRectangle(cusov, _startPosX, _startPosY, 150, 50);
            Brush door = new SolidBrush(DopColor);
            g.FillRectangle(door, _startPosX, _startPosY + 5, 10, 25);
            g.FillRectangle(door, _startPosX, _startPosY + 40, 5, 5);
            g.FillRectangle(door, _startPosX + 25, _startPosY + 5, 25, 40);
            if (BackDoors)
            {
                g.FillRectangle(door, _startPosX + 100, _startPosY + 5, 25, 40);
            }
            Brush pen = new SolidBrush(Color.Black);
            g.FillEllipse(pen, _startPosX + 5, _startPosY + 40, 20, 20);
            g.FillEllipse(pen, _startPosX + 120, _startPosY + 40, 20, 20);
            if (Garmoshka)
            {
                g.FillRectangle(pen, _startPosX + 150, _startPosY, 20, 50);

                g.FillRectangle(cusov, _startPosX + 170, _startPosY, 150, 50);

                g.FillRectangle(door, _startPosX + 195, _startPosY + 5, 25, 40);

                if (BackDoors)
                {
                    g.FillRectangle(door, _startPosX + 270, _startPosY + 5, 25, 40);
                }

                g.FillEllipse(pen, _startPosX + 175, _startPosY + 40, 20, 20);
                g.FillEllipse(pen, _startPosX + 290, _startPosY + 40, 20, 20);
            }
        }
    }

}
