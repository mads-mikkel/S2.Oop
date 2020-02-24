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

        /// <summary>
        /// Creates a new <see cref="Employee"/> with the provided <paramref name="id"/>, name and salary.
        /// </summary>
        /// <param name="id">The id in the DB</param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        /// <summary>
        /// Gets or sets the <see cref="id"/> of the employee.
        /// </summary>
        
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateId(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Id), validationResult.errorMessage);
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentException">dsfsdfs</exception>
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

        public static (bool, string) ValidateId(int id)
        {
            if(id < 0.0m)
            {
                return (false, "Id must not be negative");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}