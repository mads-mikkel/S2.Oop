using System;

namespace S2.Oop
{
    class EncapsulationProgram
    {
        static void Main()
        {
            Employee e = new Employee();
            e.Name = "Brian";
            e.Id = 45;
            e.Salary = 10000m;

            Console.WriteLine(e);

            Console.ReadLine();
        }
    }
}
