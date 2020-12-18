using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class BusComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name == y.GetType().Name)
            {
                if(x.GetType().Name == "Bus")
                {
                    return ComparerBus(x as Bus, y as Bus);
                }
                else
                {
                    return ComparerBusWithGarmoshka(x as BusWithGarmoshka, y as BusWithGarmoshka);
                }
            }
            else
            {
                if (x.GetType().Name == "Bus")
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        private int ComparerBus(Bus x, Bus y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerBusWithGarmoshka(BusWithGarmoshka x, BusWithGarmoshka y)
        {
            var res = ComparerBus(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.BackDoors != y.BackDoors)
            {
                return x.BackDoors.CompareTo(y.BackDoors);
            }
            if (x.Garmoshka != y.Garmoshka)
            {
                return x.Garmoshka.CompareTo(y.Garmoshka);
            }
            return 0;
        }
    }
}
