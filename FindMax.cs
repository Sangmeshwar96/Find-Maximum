using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class FindMaxNumber
    {

        public static int FindMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) >= 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) >= 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) >= 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) >= 0))
            {
                return thirdNum;
            }
            return default;
        }

        public static float FindMax(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) >= 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) >= 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) >= 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) >= 0))
            {
                return thirdNum;
            }
            return default;
        }

        public static string FindMax(string firstNum, string secondNum, string thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) >= 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) >= 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) >= 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) >= 0))
            {
                return thirdNum;
            }
            return default;
        }

        public static T FindMax<T>(T firstNum, T secondNum, T thirdNum)
        {
            if (Comparer<T>.Default.Compare(firstNum, secondNum) > 0 && Comparer<T>.Default.Compare(firstNum, thirdNum) > 0 ||
            Comparer<T>.Default.Compare(firstNum, secondNum) > 0 && Comparer<T>.Default.Compare(firstNum, thirdNum) > 0 ||
            Comparer<T>.Default.Compare(firstNum, secondNum) > 0 && Comparer<T>.Default.Compare(firstNum, thirdNum) > 0)
            {
                return firstNum;
            }
            if (Comparer<T>.Default.Compare(secondNum, firstNum) > 0 && Comparer<T>.Default.Compare(secondNum, thirdNum) > 0 ||
           Comparer<T>.Default.Compare(secondNum, firstNum) > 0 && Comparer<T>.Default.Compare(secondNum, thirdNum) > 0 ||
           Comparer<T>.Default.Compare(secondNum, firstNum) > 0 && Comparer<T>.Default.Compare(secondNum, thirdNum) > 0)
            {
                return secondNum;
            }
            if (Comparer<T>.Default.Compare(thirdNum, firstNum) > 0 && Comparer<T>.Default.Compare(thirdNum, secondNum) > 0 ||
          Comparer<T>.Default.Compare(thirdNum, firstNum) > 0 && Comparer<T>.Default.Compare(thirdNum, secondNum) > 0 ||
          Comparer<T>.Default.Compare(thirdNum, firstNum) > 0 && Comparer<T>.Default.Compare(thirdNum, secondNum) > 0)
            {
                return thirdNum;
            }
            return default;
        }

    }
}