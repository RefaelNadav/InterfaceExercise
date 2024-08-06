using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate) { }
        private readonly string role = "Teacher";
        public string GetRole () 
        {
            //return role; 
            return GenerateRole();
        }
        private string GenerateRole()
        {
            return "Teacher";
        }
    }
}
