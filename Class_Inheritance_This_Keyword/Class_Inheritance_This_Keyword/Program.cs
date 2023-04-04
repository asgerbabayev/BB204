using Class_Inheritance_This_Keyword.Models;

namespace Class_Inheritance_This_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ferid";
            //string surname = "Xelili";
            //int age = 20;

            //string name1 = "Aysel";
            //string surname1 = "Memmedova";
            //int age1 = 20;


            //anonimous object
            //var obj1 = new
            //{
            //    name = "Aysel",
            //    surname = "Memmedova",
            //    age = 20
            //};

            //var obj2 = new
            //{
            //    name = "Ferid",
            //    surname = "Xelili",
            //    age = 20
            //};
            //Console.WriteLine(obj1.name);


            // instance
            //Student student = new Student();


            //student.name = "Arzu";
            //student.surname = "Qocayeva";
            //student.age = 20;

            //student.Fullname();

            //Console.WriteLine(student.name + " " + student.age);
            //Console.WriteLine("{0} {1}", student.name, student.age);
            //Console.WriteLine($"{student.name} {student.age}");

            //Student student2 = new Student();
            //student2.name = "Ferid";
            //student2.surname = "Xelili";
            //student2.age = 20;
            //student2.Fullname();

            //Console.WriteLine(student.name + " " + student.age);
            //Console.WriteLine("{0} {1}", student.name, student.age);
            //Console.WriteLine($"{student2.name} {student2.age}");

            //object initializer
            Student student = new Student()
            {
                Name = "Test",
                Surname = "Test"
            };

            student.Add(student);


            student.Print();
        }
    }


}