namespace Class_Inheritance_This_Keyword.Models;

internal class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }

    private Student[] _arr = new Student[0];

    public void Add(Student student)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[_arr.Length - 1] = student;
    }

    public Student[] GetAllStudents()
    {
        return _arr;
    }

    public void Print()
    {
        foreach (Student student in GetAllStudents())
        {
            Console.WriteLine(student);
        }
    }

    public override string ToString()
    {
        return Name + Surname;
    }
}
