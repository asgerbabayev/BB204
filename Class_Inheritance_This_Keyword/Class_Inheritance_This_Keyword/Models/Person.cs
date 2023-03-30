namespace Class_Inheritance_This_Keyword.Models;

internal class Person
{
    //field
    public string name;
    public string surname;
    public int age;


    public Person(string name)
    {
        this.name = name;
    }



    public void Fullname()
    {
        Console.WriteLine($"{name} {surname} {age}");
    }
}
