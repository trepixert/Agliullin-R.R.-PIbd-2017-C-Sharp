using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsArmorAirCraft
{
    class BaseArmorAirCraft : AbstractArmorAirCraft, IComparable<BaseArmorAirCraft>, IEquatable<BaseArmorAirCraft>
    {
        protected const int AirCraftWidth = 100;
        protected const int AirCraftHeight = 60;

        public BaseArmorAirCraft(string info)
        {
            string[] mainDatas = info.Split(';');
            if (mainDatas.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(mainDatas[0]);
                Weight = Convert.ToInt32(mainDatas[1]);
                MainColor = Color.FromName(mainDatas[2]);
            }
        }
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        public int CompareTo(BaseArmorAirCraft other)
        {
            if (other == null)
                return 1;
            if (MaxSpeed != other.MaxSpeed)
                return MaxSpeed.CompareTo(other.MaxSpeed);
            if (Weight != other.Weight)
                return Weight.CompareTo(other.Weight);
            if (MainColor != other.MainColor)
                MainColor.Name.CompareTo(other.MainColor.Name);
            return 0;
        }        public bool Equals(BaseArmorAirCraft other)
        {
            if (other == null)
                return false;
            if (GetType().Name != other.GetType().Name)
                return false;
            if (MaxSpeed != other.MaxSpeed)
                return false;
            if (Weight != other.Weight)
                return false;
            if (MainColor != other.MainColor)
                return false;
            return true;
        }        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            BaseArmorAirCraft airCraftObj = obj as BaseArmorAirCraft;
            if (airCraftObj == null)
                return false;
            else
                return Equals(airCraftObj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
