﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class HangarAlreadyHaveException : Exception
    {
        public HangarAlreadyHaveException() : base ("В ангаре уже есть такой самолет!")
        {}
    }
}
