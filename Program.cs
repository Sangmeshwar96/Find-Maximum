using System;

namespace Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum of Numbers ");
            //int maxNum = FindMaxNumber.FindMax(20, 10, 20);
            //float maxNum = FindMaxNumber.FindMax(0.2f, 0.1f, 0.0f);
            //string maxNum = FindMaxNumber.FindMax("Apple", "Banana", "Mango");
            string maxNum = FindMaxNumber.FindMax<string>("Apple", "Banana", "Peach");
            Console.WriteLine(maxNum);

            int maxNumInInt = FindMaxNumber.FindMax<int>(10, 20, 30);
            Console.WriteLine(maxNumInInt);
            
        }
    }
}