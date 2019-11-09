using System;

namespace expressionbody
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add(2, 3);
            Student s1 = CreateStudent("Mohamed", 22);
            Console.WriteLine(s1.Name);
        }
        //static void Add(int fn, int sn) => Console.WriteLine($"{fn} + {sn} = {(fn + sn)}");
        static int Add(int fn, int sn) => fn + sn;
        static Student CreateStudent(string name, int age) => new Student() { Name = name, Age = age };
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
