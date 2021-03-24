using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Student> s = new Stack<Student>(5);
            s.Push(new Student("Hashir Sucks", "ZZZ"));
            s.Push(new Student("Sam", "Better than Hashir in physics"));
            s.Push(new Student("Ximan", "No,1 overwatch EU ez men"));
            s.Pop();
        }
    }
}
