using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"id:{Id} name:{Name} age:{Age} address:{Address} marks:{PhoneNumber}";

        }
    }
}
