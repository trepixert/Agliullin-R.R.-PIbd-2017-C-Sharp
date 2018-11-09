using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class AirCraft
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int AirCraftWidth = 100;
        private const int AirCraftHeight = 100;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }


        public AirCraft(int MaxSpeed, float Weight, Color MainColor, Color DopColor)
        {
            this.MaxSpeed = MaxSpeed;
            this.Weight = Weight;
            this.MainColor = MainColor;
            this.DopColor = DopColor;

        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void moveAirCraft(Direction direction)
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
        public void DrawAirCraft(Graphics g)
        {
            Pen pen = new Pen(Color.Gray);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 50, 250, 50);
            g.DrawEllipse(pen, _startPosX + 220, _startPosY-35, 80 , 220);
            g.DrawEllipse(pen, _startPosX + 110, _startPosY+10, 30, 120);
            Brush filler = new SolidBrush(DopColor);
            g.FillEllipse(filler, _startPosX + 80, _startPosY + 50, 250, 50);
            g.FillEllipse(filler, _startPosX + 220, _startPosY - 35, 80, 220);
            g.FillEllipse(filler, _startPosX + 110, _startPosY + 10, 30, 120);
        }
    }
}
