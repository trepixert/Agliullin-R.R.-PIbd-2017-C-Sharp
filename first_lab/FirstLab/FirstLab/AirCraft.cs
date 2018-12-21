using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class AirCraft : BaseArmorAirCraft, IComparable<AirCraft>, IEquatable<AirCraft>
    {
        public Color DopColor { private set; get; }
        public Color GunColor { private set; get; }
        public bool modernizide { private set; get; }
        public bool guns { private set; get; }
        private int _countLines;
        public int CountLines
        {
            set { if (value > 0 && value < 4) _countLines = value; }
            get { return _countLines; }
        }

        public AirCraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool modernizide, bool guns, Color gunColor) : base (maxSpeed, weight, mainColor)
        {
            
            MainColor = mainColor;
            DopColor = dopColor;
            GunColor = gunColor;
            this.modernizide = modernizide;
            this.guns = guns;
            Random rnd = new Random();
            CountLines = rnd.Next(1, 4);
        }

        public AirCraft(string info) : base(info)
        {
            string[] mainDatas = info.Split(';');
            if (mainDatas.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(mainDatas[0]);
                Weight = Convert.ToInt32(mainDatas[1]);
                MainColor = Color.FromName(mainDatas[2]);
                DopColor = Color.FromName(mainDatas[3]);
                modernizide = Convert.ToBoolean(mainDatas[4]);
                guns = Convert.ToBoolean(mainDatas[5]);

            }
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
                Brush Filler = new SolidBrush(Color.Black);
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

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name+";"+DopColor.Name+";"+modernizide+";"+guns;
        }

        public int CompareTo(AirCraft other)
        {
            var res = (this is BaseArmorAirCraft).CompareTo(other is BaseArmorAirCraft);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (modernizide != other.modernizide)
            {
                return modernizide.CompareTo(other.modernizide);
            }
            if (guns != other.guns)
            {
                return guns.CompareTo(other.guns);
            }
            if (GunColor != other.GunColor)
            {
                return GunColor.Name.CompareTo(other.GunColor.Name);
            }
            if ( CountLines != other.CountLines)
            {
                return CountLines.CompareTo(other.CountLines);
            }
            return 0;
        }        public bool Equals(AirCraft other)
        {
            var res = (this as BaseArmorAirCraft).Equals(other as BaseArmorAirCraft);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (modernizide != other.modernizide)
            {
                return false;
            }
            if (guns != other.guns)
            {
                return false;
            }
            if (GunColor != other.GunColor)
            {
                return false;
            }
            if (CountLines != other.CountLines)
            {
                return false;
            }
            return true;
        }
        
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            AirCraft airCraftObj = obj as AirCraft;
            if (airCraftObj == null)
            {
                return false;
            }
            else
            {
                return Equals(airCraftObj);
            }
        }        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
