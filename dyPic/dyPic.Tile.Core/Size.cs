using System;
using System.Collections.Generic;

namespace dyPic.Tile.Core
{
    public class Size : IComparable, IComparable<Size>
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public int CompareTo(Size other)
        {
            float dimension1 = Math.Max(Width, Height);
            float dimension2 = Math.Max(other.Width, other.Height);
            return dimension1.CompareTo(dimension2);
        }

        public int CompareTo(object obj)
        {
            return CompareTo(obj as Size);
        }
    }

    public class ReverseComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return -x.CompareTo(y);
        }
    }
}