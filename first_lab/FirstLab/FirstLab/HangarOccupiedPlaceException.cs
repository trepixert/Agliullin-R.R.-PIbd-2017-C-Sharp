using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class HangarOccupiedPlaceException : Exception
    {
        public HangarOccupiedPlaceException(int i):base("На месте: "+i+" уже стоит самолет")
        {}
    }
}
