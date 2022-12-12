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
            check.ToCompare(3, 2, 1);

        }
    }
}