using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.CLASS_METHODS
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight;
            this.name = aName;
            this.age = aAge;
        }
        public bool isobese()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;
        }

        
        
        

     
    }
}
