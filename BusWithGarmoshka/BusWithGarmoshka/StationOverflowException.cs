using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class StationOverflowException : Exception
    {
        public StationOverflowException() : base("На автовокзале нет свободных мест")
        { }
    }
}
