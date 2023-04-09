namespace Exceptions__Indexer__Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exceptions
            //try
            //{
            //    Console.Write("Enter a number 1: ");
            //    int n1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter a number 2: ");
            //    int n2 = Convert.ToInt32(Console.ReadLine());

            //    int resullt = n1 / n2;
            //    Console.WriteLine(resullt);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format sehfdir");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Sifira bolmek olmaz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}

            //string[] arr = { "Aysel", "Arzu", "Jale", "Aslan", "Ferid" };

            //Search search = new Search();

            //Student[] students =
            //{
            //    new Student
            //    {
            //        Name = "Aysel",
            //    },
            //    new Student
            //    {
            //        Name = "Ferid"
            //    },
            //    new Student
            //    {
            //        Name = "Aysel"
            //    }
            //};

            //try
            //{
            //    search.GetStudent(students, "nergiz");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Indexer
            //String word = "Salam";
            //Console.WriteLine(word[0].GetType());

            //Library library = new Library(5);

            //library[0] = new Book();

            //Console.WriteLine(library[0]); 
            #endregion

            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //foreach (var type in assembly.GetTypes())
            //{
            //    //Console.WriteLine($"{type.Namespace}/{type.Name}");
            //} 

            //Book book = new Book();
            //book.Name = "Test";

            //foreach (var item in book.GetType().GetMethods(
            //    System.Reflection.BindingFlags.NonPublic |
            //    System.Reflection.BindingFlags.Instance))
            //{
            //    //Console.WriteLine(item.Name);
            //    if (item.Name == "Print")
            //    {
            //        item.Invoke(book, new object[] { 5 });
            //    }
            //}
            #endregion

        }
    }

    #region Indexer
    class Library
    {
        private Book[] _books;
        public Library(int size)
        {
            _books = new Book[size];
        }
        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }
    }

    class Book
    {
        public string Name { get; set; }

        private void Print(int size)
        {
            Console.WriteLine(size + Name);
        }
    }
    #endregion

}