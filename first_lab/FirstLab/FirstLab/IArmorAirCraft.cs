using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsArmorAirCraft
{
    interface IArmorAirCraft
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveAirCraft(Direction direction);
        void DrawArmorAirCraft(Graphics g);
    }
}
