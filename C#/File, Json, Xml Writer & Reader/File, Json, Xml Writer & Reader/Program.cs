using File__Json__Xml_Writer___Reader.Models;
using System.Xml.Serialization;

namespace File__Json__Xml_Writer___Reader
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\asger\OneDrive\Masaüstü\Files\BDU\BB204\C#\File, Json, Xml Writer & Reader\File, Json, Xml Writer & Reader\Files\test.xml";
            #region Directory, File
            //Directory.CreateDirectory(@"C:\Users\asger\OneDrive\Masaüstü\BB204");
            //Directory.CreateDirectory(@"C:\Users\asger\OneDrive\Masaüstü\BB204\Inside1");
            //Directory.CreateDirectory(@"C:\Users\asger\OneDrive\Masaüstü\BB204\Inside2");
            //Directory.CreateDirectory(@"C:\Users\asger\OneDrive\Masaüstü\BB204\Inside3");

            //if (!File.Exists(path))
            //    File.Create(@"C:\Users\asger\OneDrive\Masaüstü\BB204\test.txt");
            //Directory.Delete(@"C:\Users\asger\OneDrive\Masaüstü\BB204", true); 

            //string[] arr = Directory.GetDirectories(path);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Stream Writer & Stream Reader
            //File.Create(path);

            //using (StreamWriter streamWriter = new StreamWriter(path))
            //{
            //    streamWriter.WriteLine("Arzu");
            //    streamWriter.WriteLine("Jale");
            //    streamWriter.WriteLine("Elvin");
            //    streamWriter.WriteLine("Tahir");
            //}





            //using (StreamReader streamReader = new StreamReader(path))
            //{
            //    Console.WriteLine(streamReader.ReadToEnd());
            //}

            //Console.WriteLine(streamReader.ReadLine());
            //Console.WriteLine(streamReader.ReadLine()); 
            #endregion

            #region Json serializer & deserializer
            Product p1 = new Product() { Id = 1, Name = "IPhone 15", Price = 5000 };
            Product p2 = new Product() { Id = 2, Name = "Xiaomi", Price = 800 };

            OrderItem item1 = new OrderItem() { Id = 1, Product = p1, Count = 2 };
            item1.TotalPrice = p1.Price * item1.Count;

            OrderItem item2 = new OrderItem() { Id = 2, Product = p2, Count = 3 };
            item2.TotalPrice = p2.Price * item2.Count;

            List<OrderItem> items = new List<OrderItem>() { item1, item2 };

            Order order = new Order() { Id = 1, OrderItems = items };

            //string result = JsonConvert.SerializeObject(order);

            // Stream writer json
            //using (var writer = new StreamWriter(@"C:\Users\asger\OneDrive\Masaüstü\Files\BDU\BB204\C#\File, Json, Xml Writer & Reader\File, Json, Xml Writer & Reader\Files\test.json"))
            //{
            //    writer.WriteLine(result);
            //}


            //string json = string.Empty;
            //using (var reader = new StreamReader(@"C:\Users\asger\OneDrive\Masaüstü\Files\BDU\BB204\C#\File, Json, Xml Writer & Reader\File, Json, Xml Writer & Reader\Files\test.json"))
            //{
            //    json = reader.ReadToEnd();
            //}

            //Order? order = JsonConvert.DeserializeObject<Order>(json);
            //foreach (var item in order.OrderItems)
            //{
            //    Console.WriteLine(item.Product.Name + item.Product.Price);
            //}

            //foreach (var item in order.OrderItems)
            //{
            //    Console.WriteLine($"{item.Id} {order.Id}\n{item.Count}\n{item.TotalPrice}");
            //}
            #endregion

            #region Xml serializer & deserializer

            //XmlSerializer serializer = new XmlSerializer(typeof(ValCurs));


            //using (StreamReader sr = new StreamReader(@"C:\Users\asger\OneDrive\Masaüstü\Files\BDU\BB204\C#\File, Json, Xml Writer & Reader\File, Json, Xml Writer & Reader\Files\test.xml"))
            //{
            //    //sr.ReadToEnd();
            //    ValCurs valCurs = (ValCurs)serializer.Deserialize(sr);
            //    foreach (var item in valCurs.ValType)
            //    {
            //        foreach (var item1 in item.Valute)
            //        {
            //            Console.WriteLine($"{item1.Code} - {item1}");
            //        }
            //    }
            //}

            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order));
                xmlSerializer.Serialize(sw, order);

            }

            #endregion
        }
    }
}