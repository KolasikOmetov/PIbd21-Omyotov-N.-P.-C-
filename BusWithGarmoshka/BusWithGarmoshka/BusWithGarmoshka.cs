using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class BusWithGarmoshka : Bus
    {

        public Color DopColor { private set; get; }
        public bool BackDoors { private set; get; }
        public bool Garmoshka { private set; get; }

        public BusWithGarmoshka(int maxSpeed, float weight, Color mainColor, Color dopColor, bool backDoors, bool garmoshka) : base(maxSpeed, weight, mainColor, 320, 60)
        {
            DopColor = dopColor;
            BackDoors = backDoors;
            Garmoshka = garmoshka;
        }

        public BusWithGarmoshka(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                BackDoors = Convert.ToBoolean(strs[4]);
                Garmoshka = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Brush door = new SolidBrush(DopColor);
            Brush cusov = new SolidBrush(MainColor);
            Brush pen = new SolidBrush(Color.Black);
            g.FillRectangle(door, _startPosX + 25, _startPosY + 5, 25, 40);
            if (BackDoors)
            {
                g.FillRectangle(door, _startPosX + 100, _startPosY + 5, 25, 40);
            }
            
            if (Garmoshka)
            {
                g.FillRectangle(pen, _startPosX + 150, _startPosY, 20, 50);

                g.FillRectangle(cusov, _startPosX + 170, _startPosY, 150, 50);

                g.FillRectangle(door, _startPosX + 195, _startPosY + 5, 25, 40);

                g.FillRectangle(door, _startPosX + 25, _startPosY + 5, 25, 40);

                if (BackDoors)
                {
                    g.FillRectangle(door, _startPosX + 270, _startPosY + 5, 25, 40);
                }

                g.FillEllipse(pen, _startPosX + 175, _startPosY + 40, 20, 20);
                g.FillEllipse(pen, _startPosX + 290, _startPosY + 40, 20, 20);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{BackDoors}{separator}{Garmoshka}";
        }
    }

}
