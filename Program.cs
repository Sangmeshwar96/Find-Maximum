using System;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum of Numbers ");
            int maxNum = FindMaxNumber.FindMax(20, 10, 20);
            Console.WriteLine(maxNum);
        }
    }
}