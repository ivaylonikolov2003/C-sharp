using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public double Grade { get; set; }

        public Student(String firstName, String lastName, double grade) { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString() { 
            return $"{this.FirstName} {this.LastName}: {this.Grade}";
        }

    }
}
