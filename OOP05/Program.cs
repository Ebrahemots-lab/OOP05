using OOP05.Abstract;
using OOP05.Casting_Operator;
using  OOP05.Operator_Overloading;
using OOP05.Sealed;
using OOP05.Static;
using static ProgramFunction;


namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading
            Complex c1 = new Complex() { Real = 3, Img =5};
            Complex c2 = new Complex() { Real = 3, Img = 2 };
            Complex c3 = new Complex();

            #region Binary
            //Complex c3 = c1 + c2; //Invalied Befor operator overloading
            //Complex c3 = c1 + c2;
            //Console.WriteLine(c3);

            //Complex c3 = c1 - c2;
            //Console.WriteLine(c3);

            //Complex c3 = new Complex();

            //c3 += c1;

            //Console.WriteLine(c3);
            #endregion

            #region Uniray Operator
            //Unary Operator 


            //c3 = ++c1;
            //c3 = c1++;
            //Console.WriteLine(c1);
            //c3 = --c1;
            //Console.WriteLine(c3);
            #endregion

            #region Relational Operator


            //if(c1 > c2) 
            //{
            //    Console.WriteLine("C1 > c2");
            //}
            //else 
            //{
            //    Console.WriteLine("C2 > c1");
            //}

            #endregion

            #region Casting Operator Overloading
            //int x = c2;
            //Console.WriteLine(x);

            //string comp = (string) c2;
            //Console.WriteLine(comp);

            #endregion

            #region Casting Operator Ex
            //Charcter hero = new Charcter() { Name ="Thor" , EyeColor ="Blue" , Health = 1000, Witdh = 100};

            ////we need to view it to the View
            ///*
            // * we have a hero object that came from database that hold all information about charcter but we only need to view two things the name and health so we create another class 
            // * that hold only things we need to view then we make explicit casting from the charcter th the class that hold only the information we want
            // */
            //CharcterViewModel heroView = new CharcterViewModel();
            //heroView = (CharcterViewModel) hero;
            //Console.WriteLine(heroView);

            #endregion

            #endregion

            #region Abstract
            //SavingAccount alahlyAccount = new SavingAccount(1010,"Ebrahem");
            //alahlyAccount.Deposite(200);
            //alahlyAccount.Withdraw(100);
            //Console.WriteLine(alahlyAccount);
            //alahlyAccount.Welcome();
            #endregion

            #region Static
            //We use static keyword to Use methods ot attributes without instanciate an object from this class we call it direct
           int result =  Helper.Add(1, 2);
           Console.WriteLine(result);
            #endregion

            #region Seald class
            //Simply it's a class that we can't inheart form 

            //Animal.Hello();
            #endregion

            #region Partial
            Hello();
            #endregion



        }
    }
}
