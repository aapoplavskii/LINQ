using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new string[] { "1", "2", "3", "7", "9"};

            str.Top(30);

        }

    }

    public static class DZ
    {

        public static IEnumerable<T> Top<T>(this IEnumerable<T> enumerable, int top) 
        {
            if (top < 1 || top > 100)
            {
                throw new ArgumentException("Значения не удовлетворяют условиям ДЗ");
            }

            return null;
        }
    
    }

}
