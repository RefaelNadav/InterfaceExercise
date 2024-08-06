using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Person : IPerson
    {
        private string FirstName;
        private string LastName;
        private DateTime BirthDate;
        //constructor of class
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public int GetAge()
        {
            return CalculateAge();
        }
        private int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

    }
}
