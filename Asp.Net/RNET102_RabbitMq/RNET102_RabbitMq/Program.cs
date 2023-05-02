//using RabbitMQ.Client;
//using RabbitMQ.Client.Events;
//using System.Text;

//ConnectionFactory factory = new ConnectionFactory();
//factory.Uri = new Uri("");
//using (var connection = factory.CreateConnection())
//{
//    using (var channel = connection.CreateModel())
//    {
//        channel.QueueDeclare(queue: "queue",
//                             durable: false,
//                             exclusive: false,
//                             autoDelete: true);
//        byte[] message = Encoding.UTF8.GetBytes("RNET102 Urekdir");
//        channel.BasicPublish(exchange: "", routingKey: "queue", body: message);
//    }
//}


//using (var connection = factory.CreateConnection())
//{
//    using (var channel = connection.CreateModel())
//    {
//        channel.QueueDeclare(queue: "queue",
//                             durable: false,
//                             exclusive: false,
//                             autoDelete: true);
//        EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
//        channel.BasicConsume("queue", false, consumer);
//        consumer.Received += (sender, e) =>
//        {
//            Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//        };
//    }
//}

DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
string path = Path.Combine(directoryInfo.Parent.Parent.Parent.ToString(), "Files", "example_data.xlsx");

//string connectionString = @$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={path};Extended Properties=""Excel 8.0;HDR=YES"";";
//using (OleDbConnection connection = new OleDbConnection(connectionString))
//{
//    connection.Open();
//    string query = "SELECT * FROM [sheet1$]";
//    using (OleDbDataAdapter da = new OleDbDataAdapter(query, connection))
//    {
//        DataTable dt = new DataTable();
//        da.Fill(dt);
//        foreach (var item in dt.Columns)
//        {
//            Console.WriteLine(item.ToString().Trim());
//        }
//        foreach (DataRow item in dt.Rows)
//        {
//            Console.WriteLine(item["Segment"]);
//        }
//    }
//}

//IEnumerable<ExcelDataDto> excelDatas = new ExcelMapper(path).Fetch<ExcelDataDto>();
//foreach (var item in excelDatas)
//{

//}

string a = "salam";
string b = a;
b = "b";
Console.WriteLine(a);