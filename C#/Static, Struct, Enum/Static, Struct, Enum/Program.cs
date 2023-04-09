namespace Static__Struct__Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static
            //Person person1 = new Person();
            //Console.WriteLine($"Birinci insan - Id: {person1.Id} - Count: {Person.Count}");
            //Person person2 = new Person();
            //Console.WriteLine($"Ikinci insan - Id: {person2.Id} - Count: {Person.Count}");
            //Person person3 = new Person();
            //Console.WriteLine($"Ucuncu insan - Id: {person3.Id} - Count: {Person.Count}");


            #endregion
            #region Extension
            //string word = "Salam";
            //string result = Extension.CustomReverse(word);

            //word.CustomReverse();  
            #endregion


            #region Enum
            //int weekDay = 1;

            //int choose = 0;
            //string uncle = "dayday";
            //switch (choose)
            //{
            //    case 1 when uncle == "dayday":
            //        Console.WriteLine("Transferred to hr");
            //        break;
            //}

            //string result = weekDay switch
            //{
            //    1 => "Monday",
            //    2 => "Tuesday",
            //    //discad operator
            //    _ => "wrong"
            //};

            //int day = 2;
            //switch (day)
            //{
            //    case (int)WeekDays.Monday:


            //        break;
            //    case (int)WeekDays.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    default:
            //        Console.WriteLine("Other Day");
            //        break;
            //} 
            #endregion

            #region Struct
            //Test test;
            //test.Print();


            //Test test2 = new Test();
            //test2.Print(); 
            #endregion

        }
        #region Struct

        public struct Test
        {
            public Test()
            {

            }
            public void Print()
            {
                Console.WriteLine("Hello");
            }
        }
        #endregion
    }
}