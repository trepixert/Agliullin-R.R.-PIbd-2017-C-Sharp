using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsArmorAirCraft
{
    class BaseArmorAirCraft : AbstractArmorAirCraft
    {
        protected const int AirCraftWidth = 100;
        protected const int AirCraftHeight = 60;
        public BaseArmorAirCraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveAirCraft(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - AirCraftWidth)
                        _startPosX += step;
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                        _startPosX -= step;
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                        _startPosY -= step;
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - AirCraftHeight)
                        _startPosY += step;
                    break;
            }
        }
        public override void DrawArmorAirCraft(Graphics g)
        {
            Pen pen = new Pen(Color.Gray);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 50, 250, 50);
            g.DrawEllipse(pen, _startPosX + 220, _startPosY - 35, 80, 220);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 10, 30, 120);
            Brush filler = new SolidBrush(MainColor);
            g.FillEllipse(filler, _startPosX + 80, _startPosY + 50, 250, 50);
            g.FillEllipse(filler, _startPosX + 220, _startPosY - 35, 80, 220);
            g.FillEllipse(filler, _startPosX + 110, _startPosY + 10, 30, 120);

        }
    }
}
