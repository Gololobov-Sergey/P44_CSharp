using System;
using System.Collections.Generic;
using System.Text;

namespace P44_CSharp
{
    class Point<T>/* where T :*/ /*struct*/ /*class*/ /*IComparable<T>*/ /*BaseClass*/ /*new()*/
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {
            X = default;
            Y = default;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class GA<T, T1>
    {
        public T X { get; set; }
        public T1 Z { get; set; }
    }

    class GB<T> : GA<T, int>
    {
        public T Y { get; set; }
    }
}
