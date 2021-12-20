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

            var sortlist = (from listenum in enumerable
                            orderby listenum descending
                            select listenum).Take((int)index);

            return sortlist;
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> enumerable, int top, Func<T, int> func)
        {
            if (top < 1 || top > 100)
            {
                throw new ArgumentException("Значение не удовлетворяет условиям ДЗ");
            }

            var index = Math.Round(((double)enumerable.Count() * top / 100), MidpointRounding.AwayFromZero);

            var sortlist = (from listenum in enumerable
                            orderby func(listenum) descending
                            select listenum).Take((int)index);


            return sortlist;

        }


    }

}
