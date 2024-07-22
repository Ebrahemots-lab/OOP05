
using Assignment.Second;
using Assignment.First;
using System;
using Assignment.Third;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstProject
            #region 01
            // 1 - Define 3D Point Class and the basic Constructors(use chaining in constructors).
            //Point p = new Point(10, 10, 10);

            #endregion

            #region 02
            ////2 - Override the ToString Function to produce this output:
            //Console.WriteLine(p); 
            #endregion

            #region 03
            //3 - Read from the User the Coordinates for 2 points P1, P2
            //Console.WriteLine("Enter cordinates like this => 10,20,30"); 

            //Console.Write($"enter p1 cordinates: ");
            //string userCordinatesP1 = Console.ReadLine()!;
            //int[] cordinatesP1 = Helper.GetCordinates(userCordinatesP1);
            //Point p1 = new Point(cordinatesP1[0], cordinatesP1[1], cordinatesP1[2]);

            //Console.Write($"enter p2 cordinates: ");
            //string userCordinatesP2 = Console.ReadLine()!;
            //int[] cordinatesP2 = Helper.GetCordinates(userCordinatesP2);
            //Point p2 = new Point(cordinatesP2[0], cordinatesP2[1], cordinatesP2[2]);
            #endregion

            #region 04

            //4 - Try to use == If (P1 == P2)   Does it work properly? 
            //Befor operator overloading
            //Console.WriteLine(p1 == p2); //in this Senario it will not work probably we need to overload it if we need
            //After operator overloading
            //Console.WriteLine(p1 == p2); 
            #endregion

            #region 05
            //5 - Define an array of points and sort this array based on X &Y coordinates.
            Point[] points =
            {
                new Point(10,20,30) ,
                new Point(10,15,44),
                new Point(10,40,70)
            };


            //Array.Sort(points);

            //foreach(Point po in points) 
            //{
            //    Console.WriteLine(po);
            //}

            //Another Way

            //Array.Sort(points, Helper.ComparePoints);

            //foreach(Point po in points) 
            //{
            //    Console.WriteLine(po);
            //}


            #endregion

            #region 06
            //Implement ICloneable interface to be able to clone the object

            //Point x1 = new Point(10,20,30);
            //Point x2 = new Point();

            //x2 = (Point) x1.Clone();

            //Console.WriteLine(x2);



            #endregion

            #endregion

            #region Second Project
            Mathh math = new Mathh();
            //math.Add(1,2);
            //math.Subtract(1,2);
            //math.Multiply(1,2);
            //math.Divide(1,2);

            //Mathh.Add(1,2);
            //Mathh.Subtract(1,2);
            //Mathh.Divide(1,2);
            //Mathh.Multiply(1,2);
            //Modification
            #endregion

            #region Third

            //Duraction d1 = new Duraction(7800);
            //Duraction d2 = new Duraction(666);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            Duraction d1 = new Duraction(10,20,0);
            Duraction d2 = new Duraction(4,2,0);
            Duraction d3 = new Duraction();

            //D3 = D1 + D2
            //d3 = d1 + d2;
            //Console.WriteLine(d3);

            //d3 = d1 + 7800;
            //Console.WriteLine(d3);

            //d3 = 666 + d3;
            //Console.WriteLine(d3);

            //D3 = ++D1(Increase One Minute)
            //d3 = ++d1;
            //Console.WriteLine(d3);

            //d3 = --d1;
            //Console.WriteLine(d3);

            //D1 = D1 - D2
            //d1 = d1 - d2;
            //Console.WriteLine(d1);

            //If(D1 > D2)
            //if (d1 > d2) 
            //{
            //    Console.WriteLine("Y");
            //}
            //else
            //{
            //    Console.WriteLine("nO");
            //}


            //If(D1<=D2)
            //if (d1 <= d2)
            //{
            //    Console.WriteLine("Y");
            //}
            //else
            //{
            //    Console.WriteLine("nO");
            //}

            if (d1)
            {
                Console.WriteLine("Yes");
            }

            //DateTime Obj = (DateTime)d1;
            //Console.WriteLine(Obj);
            #endregion

            
        }
    }


    class Helper
    {
        public static int[] GetCordinates(string cordinates)
        {
            string[] splitedCords = cordinates.Split(',');

            int[] convertedCords = new int[splitedCords.Length];
            //Convert items in the array
            for (int i = 0; i < splitedCords.Length; i++)
            {
                convertedCords[i] = Convert.ToInt32(splitedCords[i]);
            }
            return convertedCords;
        }


        public static int ComparePoints(Point p1 , Point p2) 
        {
            return p1.CompareTo(p2);
        }
    }
}
