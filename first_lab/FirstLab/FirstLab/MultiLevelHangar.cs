using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class MultiLevelHangar
    {
        List<Hangar<IArmorAirCraft>> hangarStages;
        private const int countPlaces = 20;

        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IArmorAirCraft>>();
            for(int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<IArmorAirCraft>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Hangar<IArmorAirCraft> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }
    }
}
