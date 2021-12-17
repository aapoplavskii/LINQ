using System;
using System.Collections.Generic;

namespace LINQ
{
    internal class WriteClass
    {
        public static void NewMethod(List<int> str, List<Person> str2)
        {
            try
            {
                var liststr = str.Top(30);

                Console.WriteLine("Вывод данных по методу расширения:");

                WriteData(liststr);
                Console.WriteLine("");

                var liststr2 = str2.Top(30, person => person.Age < 30);

                Console.WriteLine("Вывод данных по методу перегрузка:");
                WriteData(liststr2);
                Console.WriteLine("");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void WriteData<T>(IEnumerable<T> liststr)
        {
            foreach (var item in liststr)
            {
                Console.WriteLine(item);
            }
        }
    }
}