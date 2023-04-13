namespace Async_Programming
{
    internal class Program
    {
        public int Count { get; set; }
        static async Task Main(string[] args)
        {
            #region Thread
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //thread1.Start();
            //thread2.Start();
            //thread1.Join();
            //Console.WriteLine("Hello");
            //thread2.Join();


            //Loop1();
            //Loop2(); 
            #endregion

            #region Race candition
            //Program program = new Program();
            //Thread thread1 = new Thread(program.Increment);
            //Thread thread2 = new Thread(program.Decrement);

            //thread1.Start();
            //thread2.Start();
            //thread1.Join();
            //thread2.Join();

            //program.Increment();
            //program.Decrement();
            //Console.WriteLine(program.Count);
            #endregion

            #region Task

            //Stopwatch sw = new Stopwatch();


            //Task<int> resultSum = Sum(new int[] { 1, 2, 3, 4, 5 });

            //int resultDif = Difference(new int[] { 1, 2, 3, 4, 5 });

            //Console.WriteLine(resultSum.Result);

            //await resultSum;

            //List<Task<string>> tasks = new List<Task<string>>();

            //HttpClient client = new HttpClient();

            //foreach (string link in SiteUrls())
            //{
            //    tasks.Add(client.GetStringAsync(link));
            //}

            //sw.Start();
            //await Task.WhenAll(tasks);

            //foreach (var item in tasks)
            //{
            //    Console.WriteLine(item.Result.Length);
            //}
            //sw.Stop();
            //Console.WriteLine("Task 1 - " + sw.Elapsed.Seconds);

            //Console.WriteLine("-----------------------------------------------");

            //sw.Reset();
            //sw.Start();
            //foreach (var url in SiteUrls())
            //{
            //    var result = await client.GetStringAsync(url);
            //    Console.WriteLine(result.Length);
            //}
            //sw.Stop();
            //Console.WriteLine("Task 2 - " + sw.Elapsed.Seconds);


            #endregion


        }

        static string[] SiteUrls()
        {
            return new string[]
            {
                "https://github.com/",
                "https://google.com/",
                "https://microsoft.com/",
                "https://youtube.com/",
            };
        }

        static async Task<int> Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        static int Difference(int[] arr)
        {
            int diference = 0;
            foreach (int i in arr)
            {
                diference -= i;
            }
            return diference;
        }

        //void Increment()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Count++;
        //    }
        //}

        //void Decrement()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Count--;
        //    }
        //}

        #region Thread
        static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Loop1 " + i);
            }
        }

        static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Loop2 " + i);
            }
        }
        #endregion
    }
}