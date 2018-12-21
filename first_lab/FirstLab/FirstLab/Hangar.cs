using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace WindowsArmorAirCraft
{
    class Hangar<T>: IEnumerator<T>, IEnumerable<T>, IComparable<Hangar<T>>
        where T : class, IArmorAirCraft
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private int _placeSizeWidth = 210;
        private int _placeSizeHeight = 80;
        private int _currentIndex;
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }

        public Hangar(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureHeight = pictureHeight;
            PictureWidth = pictureWidth;
            _currentIndex = -1;
        }

        public static int operator +(Hangar<T> p, T AirCraft)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new HangarOverfowException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, AirCraft);
                    p._places[i].SetPosition(5 + i / 10 * p._placeSizeWidth - 80, i % 5 * (p._placeSizeHeight + 145) + 40, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Hangar<T> p,int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T airCraft = p._places[index];
                p._places.Remove(index);
                return airCraft;
            }
            throw new HangarNotFoundException(index);
        }
        private bool CheckFreePlace(int index)
        {
            return (!_places.ContainsKey(index));
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
                _places[keys[i]].DrawArmorAirCraft(g);
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for(int i = 0; i < _maxCount; i++)
            {
                for (int j = 0; j < 4; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * (_placeSizeHeight+145), i * _placeSizeWidth + 110, j * (_placeSizeHeight+145));
                }
                g.DrawLine(pen, i * (_placeSizeWidth+50), 0, i * (_placeSizeWidth+50), 450);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                    return _places[ind];
                throw new HangarNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 10 * _placeSizeWidth - 80, ind % 5 *
                    (_placeSizeHeight + 145) + 40, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new HangarOccupiedPlaceException(ind);
                }
            }
        }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(Hangar<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is BaseArmorAirCraft && other._places[thisKeys[i]] is
                            AirCraft)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is AirCraft && other._places[thisKeys[i]] is
                    BaseArmorAirCraft)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is BaseArmorAirCraft && other._places[thisKeys[i]] is BaseArmorAirCraft)
                    {
                        return (_places[thisKeys[i]] is
                       BaseArmorAirCraft).CompareTo(other._places[thisKeys[i]] is BaseArmorAirCraft);
                    }
                    if (_places[thisKeys[i]] is AirCraft && other._places[thisKeys[i]] is
                    AirCraft)
                    {
                        return (_places[thisKeys[i]] is
                       AirCraft).CompareTo(other._places[thisKeys[i]] is AirCraft);
                    }
                }
            }
            return 0;
        }
    }
}
