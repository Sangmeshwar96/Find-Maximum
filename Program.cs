using FindMaximumValue;
using System;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Program To Find The Maximum Values");
            Console.WriteLine(" ");
            //Find check = new Find();
            //check.ToCompare(3, 2, 1);
            //check.ToCompare(3.2f, 2.1f, 1.9f);
            //check.ToCompare("Patil", "Sangmeshwar", "Ramesh");
            int[] intArray = { 4, 3, 2, 1 };
            double[] doubleArray = { 1.765, 1.234, 1.345, 1.534 };
            string[] stringArray = { "Patil", "Sangmeshwar", "Ramesh" };
            Find<int> check1 = new Find<int>(intArray);
            Find<double> check2 = new Find<double>(doubleArray);
            Find<string> check3 = new Find<string>(stringArray);
            check1.PrintMax();
            check2.PrintMax();
            check3.PrintMax();

        }
    }
}