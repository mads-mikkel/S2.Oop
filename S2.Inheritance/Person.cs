using System;
using System.Linq;

namespace S2.Inheritance
{
    class Person
    {
        protected string name;
        protected DateTime birthDate;
        protected bool isAlive;

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public Person(string name, DateTime birthDate, bool isAlive)
        {
            Name = name;
            BirthDate = birthDate;
            this.isAlive = isAlive;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                (bool isValid, string message) validationResult = ValidateName(value);
                if(validationResult.isValid)
                {
                    if(name != value)
                    {
                        name = value;
                    }
                }
                else
                {
                    throw new ArgumentException(validationResult.message, nameof(Name));
                }
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public static (bool, string) ValidateName(string name)
        {
            return String.IsNullOrEmpty(name) || name.Any(c => Char.IsDigit(c)) ? (false, "Fejl") : (true, String.Empty);
        }
    }
}
