using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class _3DPoint:ICloneable,IComparable<_3DPoint>
    {
        #region Properties
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }
        #endregion

        #region Constructors

        public _3DPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public _3DPoint(int x):this(x,0,0)
        {
          
        }
        public _3DPoint(int x,int y) : this(x, y, 0)
        {

        }

        public _3DPoint(_3DPoint p)
        {
            X = p.X;
            Y = p.Y;
            Z = p.Z;

        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public object Clone()
        {
            return new _3DPoint(this);
        }

        public int CompareTo(_3DPoint? other)
        {
            if (other is not null)
            {
                if (X != other.X)
                    return X.CompareTo(other.X);
                return Y.CompareTo(other.Y);

            }
            return 1;
 
        }

        #endregion

        #region OperatorOverLoading

        public static bool operator ==(_3DPoint? p1, _3DPoint? p2)
        {
            if (p1 is not null && p2 is not null)
                return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
            
            return true;
        }

        public static bool operator !=(_3DPoint? p1, _3DPoint? p2) {
            return !(p1 == p2);
        }





        #endregion
    }
}
