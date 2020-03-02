using System;

namespace S2.Inheritance
{
    class Student: Person
    {
        private bool hasGraduated;

        public Student(string name, DateTime birthDate, bool hasGraduated)
            : base(name, birthDate)
        {
            HasGraduated = hasGraduated;
        }

        public bool HasGraduated
        {
            get
            {
                return hasGraduated;
            }

            set
            {
                hasGraduated = value;
            }
        }

        public override string ToString()
        => default;
    }
}
