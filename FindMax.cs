﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    public class Find<T> where T : IComparable 
    {
        public T[] values;
        public Find(T[] values)
        {
            this.values = values;
        }
        public T[] Sorting(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T ToCompare(params T[] values)
        {
            T[] compare = Sorting(values);
            return compare[^1];
        }
        public void Max()
        {
            T max = ToCompare(this.values);
            Console.WriteLine($"{max} is maximum");
        }
    }

}