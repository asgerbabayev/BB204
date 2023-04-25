namespace RNET102ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = new int[2];

            AddElementToArray(ref arr, 5);
            Console.WriteLine(string.Join(',', arr));

        }

        static void AddElementToArray(ref int[] numbers, int num)
        {
            int[] newArr = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[i] = numbers[i];
            }
            newArr[newArr.Length - 1] = num;

            numbers = newArr;
        }


    }
}