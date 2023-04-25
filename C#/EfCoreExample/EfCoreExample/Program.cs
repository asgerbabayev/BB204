using EfCoreExample.DAL;
using EfCoreExample.Models;

namespace EfCoreExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InsertStudent();
            //foreach (var item in GetStudents())
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}

            //Console.WriteLine(DeleteStudent(4));

            //var student = GetStudent("Aysel");
            //Console.WriteLine(student.Name + " " + student.Surname);
        }

        static void InsertStudent()
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Students.Add(new Models.Student { Name = "Aysel", Surname = "Memmedova" });
                context.SaveChanges();
            }
        }
        static List<Student> GetStudents()
        {
            using (AppDbContext context = new AppDbContext())
            {
                List<Student> students = context.Students.ToList();
                return students;
            }
        }
        static bool DeleteStudent(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Student? student = context.Students.Find();
                context.Students.Remove(student);
                var result = context.SaveChanges() > 0;
                return result;
            }
        }
        static Student? GetStudent(string name)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Student? student = context.Students.FirstOrDefault(x => x.Name == name);
                return student;
            }
        }
    }
}