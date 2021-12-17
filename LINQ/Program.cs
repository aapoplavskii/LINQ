using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var str2 = new List<Person> { new Person("Ivan", 27), new Person("Petya", 28), new Person("Kirill", 30) };
            
            WriteClass.NewMethod(str, str2);

        }
    }

}
