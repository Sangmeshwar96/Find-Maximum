using FindMaximumValue;
using System;
using static FindMaximumValue.FindMax;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program To Find The Maximum Values");
            Console.WriteLine(" ");
            FindMax check = new FindMax();
            //check.ToCompare(3, 2, 1);
            //check.ToCompare(3.2f, 2.1f, 1.9f);
            //check.ToCompare("Patil", "Sangmeshwar", "Ramesh");
            Find<int> check1 = new Find<int>(3, 2, 1);
            Find<double> check2 = new Find<double>(1.234, 1.345, 1.534);
            Find<string> check3 = new Find<string>("Patil", "Sangmeshwar", "Ramesh");
            check1.Max();
            check2.Max();
            check3.Max();

        }
    }
}