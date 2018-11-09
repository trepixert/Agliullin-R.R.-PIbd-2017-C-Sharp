using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class Hangar<T> where T : class, IArmorAirCraft
    {
        private T[] _places;
        private int PictureWidth { get; set; }
        private int PictureHeigth { get; set; }
        private int _placeSizeWidth = 210;
        private int _placeSizeHeigth = 80;
        
        public Hangar(int sizes, int pictureWidth, int pictureHeight)
        {
            _places = new T[sizes];
            PictureHeigth = pictureHeight;
            PictureWidth = pictureWidth;
            for (int i = 0; i < _places.Length; i++)
                _places[i] = null;
        }

        public static int operator +(Hangar<T> p, T AirCraft)
        {
            for(int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = AirCraft;
                    p._places[i].SetPosition(5 + i / 10 * p._placeSizeWidth - 80,i%5*(p._placeSizeHeigth+145)+40, p.PictureWidth,p.PictureHeigth);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Hangar<T> p,int index)
        {
            if (index < 0 || index > p._places.Length)
                return null;
            if (!p.CheckFreePlace(index))
            {
                T AirCraft = p._places[index];
                p._places[index] = null;
                return AirCraft;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for(int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i))
                    _places[i].DrawArmorAirCraft(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for(int i = 0; i < _places.Length / 5; i++)
            {
                for (int j = 0; j < 4; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * (_placeSizeHeigth+145), i * _placeSizeWidth + 110, j * (_placeSizeHeigth+145));
                }
                g.DrawLine(pen, i * (_placeSizeWidth+50), 0, i * (_placeSizeWidth+50), 450);
            }
        }
    }
}
