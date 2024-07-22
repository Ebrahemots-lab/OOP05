using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Img { get; set; }


        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }


        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Img = (a?.Img ?? 0) + (b?.Img ?? 0),
            };
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Img = (a?.Img ?? 0) - (b?.Img ?? 0),
            };
        }

        public static Complex operator ++(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) + 1,
                Img = a?.Img ?? 0

            };


        }

        public static Complex operator --(Complex a)
        {
            return new Complex()
            {
                Real = (a?.Real ?? 0) - 1,
                Img = a?.Img ?? 0

            };

        }

  


        public static bool operator > (Complex a , Complex b) 
        {
            //a.rel == b.real -> a.img > b.img
            //a.real != b.real -> check the Real

            if(a.Real == b.Real) 
            {
                return a.Img > b.Img;
            }
            else 
            {
                return a.Real > b.Real;
            }
        }


        public static bool operator <(Complex a, Complex b)
        {
            //a.rel == b.real -> a.img > b.img
            //a.real != b.real -> check the Real

            if (a.Real == b.Real)
            {
                return a.Img < b.Img;
            }
            else
            {
                return a.Real < b.Real;
            }
        }

        #region Casting Overloading
        public static implicit operator int(Complex c)
        {
            return c.Real;
        }

        public static explicit operator string(Complex c) 
        {
            return $"Your Value is {c?.Real ?? 0}";
        }
        #endregion

    }
}
