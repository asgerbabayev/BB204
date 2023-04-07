using Utilities.Exceptions;

namespace Utilities.Services;

public class Search
{
    public bool Find(string[] arr, string word)
    {
        foreach (var item in arr)
        {
            if (item.Trim().ToLower() == word.Trim().ToLower())
            {
                return true;
            }
        }
        throw new Exception("dsdsasadasdadda");

    }

    public Student GetStudent(Student[] students, string name)
    {
        foreach (var student in students)
        {
            if (student.Name.Trim().ToLower() == name.Trim().ToLower())
            {
                return student;
            }
        }
        throw new StudentNullException("Student yoxdur");
    }
}

public class Student
{
    public string Name { get; set; }
}
