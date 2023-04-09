namespace Record__Type_C_9.Models;

record Student
{
    public string Name { get; init; }
    public string Surname { get; init; }
    public int Age { get; init; }

}
//Shorthand declaring
record Student1(string name, string surname, int age);
