using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P44_CSharp
{
    enum Coordinate
    {
        X,
        Y
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        
        public static Point operator-(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y };
        }

        public static Point operator++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator--(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }


        public static Point operator+(Point p1, Point p2)
        {
            return new Point() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }


        public static Point operator -(Point p1, Point p2)
        {
            return new Point() { X = p1.X - p2.X, Y = p1.Y - p2.Y };
        }

        
        public static Point operator +(Point p1, int m)
        {
            return new Point() { X = p1.X + m, Y = p1.Y + m };
        }

        public static Point operator +(int m, Point p1)
        {
            return new Point() { X = p1.X + m, Y = p1.Y + m };
        }


        public static bool operator==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }


        public static bool operator!=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator true(Point p1)
        {
            return p1.X != 0 || p1.Y != 0;
        }

        public static bool operator false(Point p1)
        {
            return p1.X == 0 && p1.Y == 0;
        }


        public static /*implicit*/ explicit operator float(Point p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        public int this[string index]
        {
            get
            {
                if (index == "X")
                    return X;
                else if (index == "Y")
                    return Y;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index == "X")
                    X = value;
                else if (index == "Y")
                    Y = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public int this[int index1, int index]
        {
            get
            {
                if (index1 == 0 && index == 0)
                    return X;
                else if (index1 == 0 && index == 1)
                    return Y;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index1 == 0 && index == 0)
                    X = value;
                else if (index1 == 0 && index == 1)
                    Y = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }


        public int this[Coordinate coord]
        {
            get
            {
                if (coord == Coordinate.X)
                    return X;
                else if (coord == Coordinate.Y)
                    return Y;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (coord == Coordinate.X)
                    X = value;
                else if (coord == Coordinate.Y)
                    Y = value;
                else
                    throw new IndexOutOfRangeException("Invalid index");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Point({X}, {Y})");
        }


    }
}
