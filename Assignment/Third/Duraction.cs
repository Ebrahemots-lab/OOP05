using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third
{
    internal class Duraction
    {
        public int Hours;

        public int Min;

        public int Seconds;


        public Duraction()
        {

        }

        public Duraction(int hours, int min, int seconds)
        {
            Hours = hours;
            Min = min;
            Seconds = seconds;
        }

        public Duraction(int seconds) : this(seconds / 3600, (seconds % 3600) / 60, (seconds % 3600) % 60)
        {
            //7800 / 60 => 130 
            //Hours = seconds / 3600; // 2

            //int remainingSeconds = seconds % 3600;

            //int minutes = remainingSeconds / 60;

            //int totalSeconds = remainingSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hourse: {Hours} , Minutes: {Min} , Seconds: {Seconds}";
        }

        //public override bool Equals(object? obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}



        #region Overloading
        public static Duraction operator +(Duraction d1, Duraction d2)
        {
            return new Duraction()
            {
                Hours = (d1?.Hours ?? 0) + (d2?.Hours ?? 0),
                Min = (d1?.Min ?? 0) + (d2?.Min ?? 0),
                Seconds = (d1?.Seconds ?? 0) + (d2?.Seconds ?? 0)
            };
        }

        public static Duraction operator -(Duraction d1, Duraction d2)
        {
            return new Duraction()
            {
                Hours = (d1?.Hours ?? 0) - (d2?.Hours ?? 0),
                Min = (d1?.Min ?? 0) - (d2?.Min ?? 0),
                Seconds = (d1?.Seconds ?? (d1.Seconds <= 0 ? 0 : d1.Seconds)) - (d2?.Seconds ?? (d2.Seconds <= 0 ? 0 : d2.Seconds))
            };
        }

        public static Duraction operator +(Duraction d1, int seconds)
        {
            //7800 / 60 => 130

            int remainingSeconds = seconds % 3600;

            int minutes = remainingSeconds / 60;

            int totalSeconds = remainingSeconds % 60;

            return new Duraction()
            {
                Hours = d1.Hours + (seconds / 3600),
                Min = d1.Min + minutes,
                Seconds = seconds + totalSeconds,
            };
        }



        public static Duraction operator +(int seconds, Duraction d1)
        {
            //7800 / 60 => 130

            int remainingSeconds = seconds % 3600;

            int minutes = remainingSeconds / 60;

            int totalSeconds = remainingSeconds % 60;

            return new Duraction()
            {
                Hours = d1.Hours + (seconds / 3600),
                Min = d1.Min + minutes,
                Seconds = seconds + totalSeconds,
            };
        }

        public static Duraction operator ++(Duraction d)
        {
            return new Duraction()
            {
                Min = d.Min + 1
            };
        }

        public static Duraction operator --(Duraction d)
        {
            return new Duraction()
            {
                Min = d.Min - 1
            };
        }

        public static bool operator >(Duraction d1, Duraction d2) 
        {
            return d1.Hours > d2.Hours;
        }

        public static bool operator <(Duraction d1, Duraction d2)
        {
            return d1.Hours < d2.Hours;
        }

        public static bool operator <=(Duraction d1, Duraction d2)
        {
            return d1.Hours <= d2.Hours;
        }

        public static bool operator >=(Duraction d1, Duraction d2)
        {
            return d1.Hours >= d2.Hours;
        }


        public static implicit operator bool (Duraction d1) 
        {
            return d1.Seconds == 0;
        }  
        public static explicit operator DateTime(Duraction d) 
        {
            return new DateTime(2023,5,12,minute:d.Min,hour:d.Hours,second:d.Seconds);
          
        }
        #endregion


    }
}
