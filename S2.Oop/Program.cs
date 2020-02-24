using System;

namespace S2.Oop
{
    class EncapsulationProgram
    {
        static void Main()
        {
            int input = -87;

            (bool isValid, string errorMessage) validationResult = Employee.ValidateId(input);
            if(!validationResult.isValid)
            {
                Console.WriteLine(validationResult.errorMessage);
            }
            else
            {
                Employee employee = new Employee(input, "", 54m);
            }
        }
    }
}
