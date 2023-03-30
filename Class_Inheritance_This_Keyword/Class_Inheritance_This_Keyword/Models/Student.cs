namespace Class_Inheritance_This_Keyword.Models;

internal class Student : Person
{


    public Student(string name) : base(name)
    {

    }

    public Student(string name, double point) : base(name)
    {
        this.point = point;
    }


    //public Student(string name, int age) : this(name)
    //{
    //    this.age = age;
    //}

    //public Student(string name, string surname, int age) : this(name, age)
    //{
    //    this.surname = surname;
    //}
    public double point;


}
