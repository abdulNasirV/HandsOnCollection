using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    public class Student
    {
        static void Main(string[] args)
        {

            List<string> stringList = new List<string>() { "Michael", "Aiden", "Sara", "James", "Sam", "Max" };
            Console.WriteLine("Result before sorting");
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }

            stringList.Sort();
            Console.WriteLine();
            Console.WriteLine("Result after sorting");
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }

        }
    }
}