using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class AirCraft : BaseArmorAirCraft
    {
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public Color GunColor { private set; get; }
        public bool modernizide { private set; get; }
        public bool guns { private set; get; }

        public AirCraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool modernizide, bool guns, Color gunColor) : base (maxSpeed, weight, mainColor)
        {
            
            MainColor = mainColor;
            DopColor = dopColor;
            GunColor = gunColor;
            this.modernizide = modernizide;
            this.guns = guns;
        }

        public override void DrawArmorAirCraft(Graphics g)
        {
            Pen pen = new Pen(DopColor);
            
            if (guns)
            {
                g.DrawEllipse(pen, _startPosX + 220+30, _startPosY + 20, 80, 25);
                g.DrawEllipse(pen, _startPosX + 220 + 30, _startPosY - 10, 70, 25);
                g.DrawEllipse(pen, _startPosX + 220 + 30, _startPosY + 100, 80, 25);
                g.DrawEllipse(pen, _startPosX + 220 + 30, _startPosY + 130, 70, 25);
                Brush Filler = new SolidBrush(GunColor);
                g.FillEllipse(Filler, _startPosX + 220 + 30, _startPosY + 20, 80, 25);
                g.FillEllipse(Filler, _startPosX + 220 + 30, _startPosY - 10, 70, 25);
                g.FillEllipse(Filler, _startPosX + 220 + 30, _startPosY + 100, 80, 25);
                g.FillEllipse(Filler, _startPosX + 220 + 30, _startPosY + 130, 70, 25);
 
            }
            if (modernizide)
            {
                g.DrawEllipse(pen, _startPosX + 80, _startPosY + 45, 250, 60);
                g.DrawEllipse(pen, _startPosX + 215, _startPosY - 35, 90, 220);
                g.DrawEllipse(pen, _startPosX + 105, _startPosY + 10, 40, 120);
                Brush filler = new SolidBrush(DopColor);
                g.FillEllipse(filler, _startPosX + 80, _startPosY + 45, 250, 60);
                g.FillEllipse(filler, _startPosX + 215, _startPosY - 35, 90, 220);
                g.FillEllipse(filler, _startPosX + 105, _startPosY + 10, 40, 120);
            }
            base.DrawArmorAirCraft(g);
        }
        public override void MoveAirCraft(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Left:
                    if (_startPosX + step < _pictureWidth - AirCraftWidth)
                        _startPosX += step;
                    break;
                case Direction.Right:
                    if (_startPosX - step > 0)
                        _startPosX -= step;
                    break;
                case Direction.Down:
                    if (_startPosY - step > 0)
                        _startPosY -= step;
                    break;
                case Direction.Up:
                    if (_startPosY + step < _pictureHeight - AirCraftHeight)
                        _startPosY += step;
                    break;
            }
        }
    }
}
