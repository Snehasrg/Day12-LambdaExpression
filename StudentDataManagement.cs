using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class StudentDataManagement
    {
        public static void DisplayFrequencyofEachAddress(List<Student> list)
        {
            Console.WriteLine("\nDisplaying Details Based on Address");
            var res = list.GroupBy(a => a.Address);
            foreach(var r in res)
            { 
                Console.WriteLine("Key:", r.Key);
                Console.WriteLine("-------------------");

                List<Student> students =r.ToList();
                foreach(Student s in students) 
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }

    }
}
