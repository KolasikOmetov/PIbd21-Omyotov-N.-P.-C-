using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWithGarmoshka
{
    class StationAlreadyHaveException : Exception
    {
        public StationAlreadyHaveException() : base("На автовокзале уже есть такой автобус")
        { }
    }
}
