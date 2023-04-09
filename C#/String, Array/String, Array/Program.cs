namespace String__Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String
            //string word1 = "Hello";
            //string word2 = word1;
            //word2 = "Hi";
            //Console.WriteLine($"{word1} {word2}");
            //String.Concat(word1, word2);

            //string word = "Hello Hello Hello".ToLower();


            //string result = word.Replace('1', '9');
            //bool result = word.Contains("2");

            //bool result = word.EndsWith(' ');
            //int result = word.IndexOf('E'.ToString().ToLower());
            //int result = word.IndexOf('e');
            //int result = word.LastIndexOf('e');

            //string result = word.Remove(2, 2);
            //Console.WriteLine(result);

            //string[] arr = word.Split(',', ' ');

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}



            //string input = Console.ReadLine().Trim().ToLower();


            //Console.WriteLine(word.Length);
            //Console.WriteLine(word.Trim().Length);

            //string word = "Hello";
            //Console.WriteLine(Reverse(word));

            #endregion

            #region String Builder
            //StringBuilder builder = new StringBuilder();
            //builder.AppendLine("Hello ");
            //builder.Append("World");
            //Console.WriteLine(builder);
            #endregion

            #region Array and Regex

            //int[] arr = { 185, 12, 3 };
            //Resize(ref arr, 4);
            //Array.Resize(ref arr, 4);
            //Console.WriteLine(string.Join(',', arr));
            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (int i in arr)
            //{
            //    stringBuilder.Append(i);
            //    stringBuilder.Append(",");
            //}
            //Console.Write(stringBuilder.ToString().TrimEnd(','));

            //Array.Reverse(arr);
            //Array.Sort(arr);

            //string word = "dasdasd";
            //Regex regex = new Regex("^$");
            //Console.WriteLine(regex.IsMatch(word));

            //Console.WriteLine(string.Join(',', arr));

            #endregion
        }

        //static string Reverse(string word)
        //{
        //    string reversed = string.Empty;
        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        reversed += word[i];
        //    }
        //    return reversed;
        //}

        //static int[] Resize(ref int[] arr, int size)
        //{
        //    int[] newArr = new int[size];
        //    int i = 0;
        //    while (i < arr.Length)
        //    {
        //        newArr[i] = arr[i];
        //        i++;
        //    }
        //    arr = newArr;
        //    return arr;
        //}
    }
}