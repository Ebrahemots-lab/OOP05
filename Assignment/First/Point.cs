using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First
{
    internal class Point : IComparable , IComparer , ICloneable
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int  Z { get; set; }


        public Point()
        {
            //Do Nothing
        }

        public Point(int _x)
        {
            X = _x;
        }

        public Point(int _x , int _y):this(_x)
        {
            Y = _y;
        }

        public Point(int _x , int _y , int _z):this(_x,_y)
        {
            Z = _z;
        }

        public int CompareTo(object? obj)
        {
            //Convert this object to POint 
            Point point = (Point) obj;

            if(X > point.X) 
            {
                return 1;
            }
            else if (X < point.X)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        public override string ToString()
        {
            return $"Point Coordinates ({X},{Y},{Z})";
        }

        public int Compare(object? x, object? y)
        {
           Point p1 = (Point) x;
           Point p2 = (Point) y;

            if((p1?.X ?? 0) != (p2?.X ?? 0)) 
            {
                return p1.X.CompareTo(p2.X);
            }
            else 
            {
                return p1.Y.CompareTo(p2.Y);
            }
        }

        public object Clone()
        {
            //Deep Copy
            return new Point
            {
                X = X,
                Y = Y,
                Z = Z
            };
        }



        #region Operator Overloading
        public static bool operator == (Point a , Point b) 
        {
            bool flag = false;
            if (a.X == b.X && a.Y == b.Y && a.Z == b.Z)
            {
                flag = true;
            }
            else 
            {
                flag = false;            
            }
            return flag;
           
        }

        public static bool operator !=(Point a, Point b)
        {
            return a.X != a.Z;
        }
        #endregion
    }
}
