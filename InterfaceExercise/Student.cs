using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Student : Person
    {
        public Student(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate){}
        //private readonly string role = "Student";
        public string GetRole()
        {
            return GenerateRole();
        }

        private string GenerateRole()
        {
            return "Student";
        }
    }
    
}
