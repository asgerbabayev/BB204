namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Reference
            //int a = 5;

            //int c = a;

            ////       string interpolation
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"c = {c}");


            //int[] arr = { 1, 2, 3 };
            //int[] arr1 = arr;

            //arr[0] = 2;

            //int[] arr1 = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr1[i] = arr[i];
            //}

            //foreach (int i in arr1)
            //{
            //    Console.WriteLine(i);
            //}

            //arr1[0] = 5; 
            #endregion

            #region Ref Out
            //int[] numbers = { 1, 2, 3 };
            //ChangeNumber(numbers);
            //Console.WriteLine(numbers[0]);

            //ChangeNumber(out int number);

            //Console.WriteLine(number);

            //EnterName:
            //    EnterName(out string name);
            //    bool checkName = CheckName(name);
            //    if (checkName == false)
            //       goto EnterName;

            //EnterName(out string name);

            //int[] nums = { 1, 2, 7 };
            //Arr(ref nums, 3);
            //Console.WriteLine(nums);
            #endregion


        }

        #region Ref Out
        static void EnterName(out string name)
        {
            do
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
            } while (!CheckName(name));
        }

        static bool CheckName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) return false;
            return true;
        }
        static void ChangeNumber(out int num)
        {
            num = 5;
            Console.WriteLine(num);
        }


        static void ChangeArrElem(int[] arr)
        {
            arr[0] = 5;
            Console.WriteLine(arr[0]);
        }
        static void Arr(ref int[] arr, int num)
        {
            int[] array = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            array[array.Length - 1] = num;

            arr = array;
        }
        #endregion

    }
}