using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class HangarOverfowException : Exception
    {
        public HangarOverfowException() : base("В ангаре нет свободных мест")
        { }
    }
}
