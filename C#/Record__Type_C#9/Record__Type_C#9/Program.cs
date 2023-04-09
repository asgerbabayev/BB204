using Record__Type_C_9.Models;

namespace Record__Type_C_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student st1 = new Student()
            {
                Name = "Test",
                Surname = "Test",
                Age = 1,
            };

            Student st2 = new Student()
            {
                Name = "Test",
                Surname = "Test",
                Age = 1,
            };


            //Student1 student1 = new Student1(name: "", surname: "", age: 15);


            Console.WriteLine(st1 == st2);
            Console.WriteLine(st1.Equals(st2));

        }
    }



}