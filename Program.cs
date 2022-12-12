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
            FindMax check = new FindMax();
            //check.ToCompare(3, 2, 1);
            //check.ToCompare(3.2f, 2.1f, 1.9f);
            check.ToCompare("Patil", "Sangmeshwar", "Ramesh");

        }
    }
}