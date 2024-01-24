using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.CLASS_METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "john", 15);
            Student student2 = new Student(40, "tim", 16);

            Console.WriteLine(student1.isobese());
            Console.WriteLine(student2.isobese());

            Console.Read();


        }
    }
}
