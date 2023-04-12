namespace Delegate__Lambda_Expression
{
    public delegate R Calculator<in T, out R>(T n1, T n2);

    public delegate bool Result(int n1, int n2);

    public delegate bool Check(int n1, int n2);

    delegate void CustomAction(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate
            ////Anonymous delegate
            ////Write write = delegate (string a)
            ////{
            ////    Console.WriteLine(a);
            ////};
            //Write write = PrintFirstCharacter;
            //write("Salam");
            ////PrintFirstCharacter("dasda");

            //Calculator<int> sum = delegate (int n1, int n2)
            //{
            //    return n1 + n2;
            //};

            //Console.WriteLine(sum(5, 6));

            ////sum.Invoke(5, 6);


            //Calculator<double> divide = delegate (double n1, double n2)
            //{
            //    return n1 / n2;
            //};

            ////int[] arr = { 1, 2, 3, 56, 7, 8, 152 };

            ////Sum(arr, IsOdd);
            ////Sum(arr, IsEven);
            ////Sum(arr, IsPositife);


            ////Arrow functions or Lambda Expression
            ////Check check = (n1, n2) =>
            ////{
            ////    return n1 > n2;
            ////};

            ////Console.WriteLine(check.Invoke(5, 3)); 
            #endregion

            #region Action
            //Action<string> action = delegate (string text)
            //{
            //    Console.WriteLine(text);
            //};


            //action += Print;

            //action += (text) =>
            //{
            //    Console.WriteLine("Arrow Function - " + text);
            //};


            //action.Invoke("");
            //action("test"); 
            #endregion

            #region Func
            //Func<int, bool> func = (value) =>
            //{
            //    return value > 0;
            //};

            //Func<int, int, bool> func = delegate (int x, int y)
            //{
            //    return x == y;
            //};

            //Console.WriteLine(func.Invoke(-4));

            //Func<double, double, double> func = Divide;

            //Console.WriteLine(func.Invoke(3.5, 5.6));
            #endregion

            #region Predicate
            //Predicate<string> predicate = (i) =>
            //{
            //    return true;
            //}; 
            #endregion

            #region Delegate methods
            //Check check = (n1, n2) => n1 > n2;

            //List<Student> list = new List<Student>();

            //list.Add(new Student { Name = "Arzu" });
            //list.Add(new Student { Name = "Aysel" });

            //var result = list.Find(s => s.Name == "Arzu");
            //List<int> result = list.FindAll(s => s == 15);

            //result.ForEach(x =>
            //{
            //    Console.WriteLine(x);
            //});

            //result.FirstOrDefault(x => x == 15);

            //Console.WriteLine(result);

            //foreach (var item in list)
            //{
            //    if (item == 15)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine(result); 
            #endregion


        }

        #region Delegate
        //static int Sum(int[] arr, Check check)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (check(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        static int SumEven(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (IsEven(item))
                {
                    sum += item;
                }
            }
            return sum;
        }

        bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        static bool IsPositife(int n)
        {
            return n > 0;
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }
        static void PrintFirstCharacter(string str)
        {
            Console.WriteLine(str[0]);
        }
        static void PrintLastCharacter(string str)
        {
            Console.WriteLine(str[str.Length - 1]);
        }
        #endregion

    }

    class Student
    {
        public string Name { get; set; }
    }
}