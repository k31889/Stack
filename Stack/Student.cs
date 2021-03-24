using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Student
    {
        private string name;
        private string grade;

        public Student(string n, string g)
        {
            name = n;
            grade = g;
        }

        public string getName()
        {
            return name;
        }

        public string getGrade()
        {
            return grade;
        }

        public void Print()
        {
            Console.WriteLine("{0}, {1}", name, grade);
        }
    }
}
