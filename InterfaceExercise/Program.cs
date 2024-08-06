// See https://aka.ms/new-console-template for more information
using InterfaceExercise;

Student s1 = new Student("Moshe", "cohen", DateTime.Now);
Teacher t1 = new Teacher("Yarden", "Shua", DateTime.Now.AddYears(-25));
Console.WriteLine(s1.GetFullName());
Console.WriteLine(s1.GetAge());
Console.WriteLine(s1.GetRole());

Console.WriteLine(t1.GetFullName());
Console.WriteLine(t1.GetAge());
Console.WriteLine(t1.GetRole());

List<IPerson> persons = new List<IPerson>();
persons.Add(s1);
persons.Add(t1);

foreach (IPerson item in persons)
{
    if(item is Teacher)
    {
        Console.WriteLine(item.GetFullName());
    }
    else
    {
        Console.WriteLine(item.GetAge());
    }
}
