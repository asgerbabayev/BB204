using System.Text;

namespace Generics___Collections
{
    internal class Program : Object
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Generic Types and Constraints
            //MyIntList myIntList = new MyIntList();
            //myIntList.Add(1);
            //myIntList.Add(2);
            //myIntList.Add(3);

            //MyStrList myStrList = new MyStrList();

            //myStrList.Add("sadasd");

            //MyList<string> myList = new MyList<string>();
            //myList.Add("sadas");
            //myList.Add(5);
            //myList.Add(true);

            //Student student = new Student();

            //myList.Add(new Student() { Name = "Ferid" });

            //MyList<Student, int> myList = new MyList<Student, int>();

            //myList.Add(new Student() { Name = "Aysel" });
            //myList.Print(5);

            //MyList<string> str = new MyList<string>();

            //MyList<Test> struct1 = new MyList<Test>();

            //str.Add("1"); 
            #endregion

            #region Non-generic collection
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("");
            //arrayList.Add(new Student());
            //arrayList.Add(new Program());

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //List<string> list2 = new List<string>();
            #endregion

            #region Generic collection
            //List<Student> students = new List<Student>();

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //students.Count


            // students.Add(new Student() { Name = name, Age = age });


            // bulk insert
            //students.AddRange(new List<Student>
            //{
            //    new Student() { Name = "Aslan" }   ,
            //    new Student() { Name = "Arzu" }    ,
            //    new Student() { Name = "Jale" }    ,
            //    new Student() { Name = "Nergiz" }  ,
            //    new Student() { Name = "Aysel" }   ,
            //    new Student() { Name = "Ferid" }   ,
            //    new Student() { Name = "Tahir" }   ,
            //    new Student() { Name = "Sitare" }  ,
            //    new Student() { Name = "Elvin" }
            //});

            //foreach (Student student in students)
            //{
            //if (student.Name == "Tahir")
            //{
            //students.Remove(student);
            //Console.WriteLine($"Name : {student.Name} - Age : {student.Age}");
            //}
            //}



            //students.AddRange();

            //Console.WriteLine(students.Count);
            #endregion


            #region Stack and Queue
            //Stack<Book> stack = new Stack<Book>();
            //stack.Push(new Book() { Name = "LOTR" });
            //stack.Push(new Book() { Name = "Angels and Demons" });
            //stack.Push(new Book() { Name = "Davinci's Code" });
            //stack.Push(new Book() { Name = "Harry Potter" });
            //stack.Push(new Book() { Name = "Ego Düşmendir" });

            //stack.Pop();

            //foreach (Book book in stack)
            //{
            //    Console.WriteLine(book.Name);
            //}

            //Queue<Book> queue = new Queue<Book>();

            //queue.Enqueue(new Book() { Name = "LOTR" });
            //queue.Enqueue(new Book() { Name = "Alternatif Əməliyyat" });

            //queue.Dequeue();

            //foreach (Book book in queue)
            //{
            //    Console.WriteLine(book.Name);
            //} 
            #endregion
        }
    }


    #region Generic Types
    class MyList<T>
    //generic constraints
    //where T : struct
    //where T : class
    //where T1 : new()
    {
        private T[] _arr;
        public MyList()
        {
            _arr = new T[10];
        }
        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }

    //class MyList
    //{
    //    private object[] _arr;
    //    public MyList()
    //    {
    //        _arr = new object[0];
    //    }

    //    public void Add(object value)
    //    {
    //        Array.Resize(ref _arr, _arr.Length + 1);
    //        _arr[_arr.Length - 1] = value;
    //    }
    //}

    class MyIntList
    {
        private object[] _arr;
        public MyIntList()
        {
            _arr = new object[0];
        }

        public void Add(object value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }

    class MyStrList
    {
        private string[] _arr;
        public MyStrList()
        {
            _arr = new string[0];
        }

        public void Add(string value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }
    class MyStudentList
    {
        private Student[] _arr;
        public MyStudentList()
        {
            _arr = new Student[0];
        }

        public void Add(Student value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }
    #endregion

    class Book
    {
        public string Name { get; set; }
    }
}