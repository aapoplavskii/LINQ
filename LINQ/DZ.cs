using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public static class DZ
    {

        public static IEnumerable<T> Top<T>(this IEnumerable<T> enumerable, int top)
        {
            if (top < 1 || top > 100)
            {
                throw new ArgumentException("Значение не удовлетворяет условиям ДЗ");
            }

            var index = Math.Round(((double)enumerable.Count() * top / 100), MidpointRounding.AwayFromZero);

            var list = new List<T>();

            for (int i = enumerable.Count() - 1; i >= enumerable.Count() - index; i--)
            {
                list.Add(enumerable.ElementAt(i));
            }

            return list;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> enumerable, int top, Func<T, bool> func)
        {
            if (top < 1 || top > 100)
            {
                throw new ArgumentException("Значение не удовлетворяет условиям ДЗ");
            }

            var list = new List<T>();
            foreach (var item in enumerable)
            {
                if (func(item) == true)
                { 
                    list.Add((T)item);
                }
            }
            
            return list;

        }

        
    }

}
