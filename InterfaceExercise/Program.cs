// See https://aka.ms/new-console-template for more information
using InterfaceExercise;

Console.WriteLine("Hello, World!");

Student s1 = new Student("Moshe", "cohen", DateTime.Now);
Console.WriteLine(s1.GetFullName());
Console.WriteLine(s1.GetAge());
Console.WriteLine(s1.GetRole());