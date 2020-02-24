using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2.Oop
{
    public class Employee
    {
        private int id;
        private string name;
        private decimal salary;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Id), "Id must not be negative");
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is null, empty or whitespace", nameof(Name));
                }
                if(value.Any(c => Char.IsDigit(c)))
                {
                    throw new ArgumentException("Name must not contain numbers", nameof(Name));
                }
                if(value != name)
                {
                    name = value;
                }
            }
        }
        public decimal Salary 
        {
            get => salary;
            set
            {
                if(salary < 0.0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(Salary), "Salary must not be negative. The slave times are over.");
                }
                if(value != salary)
                {
                    salary = value;
                }
            }
        }

        public override string ToString()
            => $"Id: {id}\tNavn: {name}\tLøn: {salary.ToString("c")}";
    }
}