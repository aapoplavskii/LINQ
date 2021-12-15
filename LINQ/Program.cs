using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            try
            {
                var liststr = str.Top(30);

                WriteData(liststr);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void WriteData(IEnumerable<int> liststr)
        {
            foreach (var item in liststr)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static class DZ
    {

        public static IEnumerable<T> Top<T>(this IEnumerable<T> enumerable, int top) 
        {
            if (top < 1 || top > 100)
            {
                throw new ArgumentException("Значение не удовлетворяет условиям ДЗ");
            }

            var index = Math.Round(((double)enumerable.Count()*top/100), MidpointRounding.AwayFromZero);

            var list = new List<T>();

            for (int i = enumerable.Count()-1; i >= enumerable.Count()-index; i--)
            {
                list.Add(enumerable.ElementAt(i));
            }

            return list;
        }

        public static IEnumerable<TSource> Top<TSource>(this IEnumerable<TSource> enumerable, int top, Func<TSource, bool> func)
        {

            return null;
        
        }
    }

}
