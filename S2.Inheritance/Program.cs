using System;

namespace S2.Inheritance
{
    class Program
    {
        static void Main()
        {
            Person deadPerson = new Person("Kim Larsen", new DateTime(1940, 01, 10), true);
            Person p = new Person("Mads", new DateTime(1983, 05, 19));
            Student s = new Student("Ole", new DateTime(1957, 12, 15), true);

        }
    }
}
