using Ado.Net_EntitiyFrameworkCore.Models;
using System.Data;
using System.Data.SqlClient;

namespace Ado.Net_EntitiyFrameworkCore
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server = ADMIN; Database = Northwind;
                                                   Integrated Security = True";
        static void Main(string[] args)
        {
            //Console.WriteLine(GetName());


            //Insert(companyName, phone);

            //List<Shipper> result = GetAllShippersConnected();
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");

            //}

            //DeleteShipper(3);


            GetAllShippersDisConnected();

        }

        static string GetName(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                //sql injection
                //string query = $"SELECT LastName FROM Employees Where EmployeeID = {id}";
                string query = $"SELECT LastName FROM Employees Where EmployeeID = @id";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                var result = command.ExecuteScalar().ToString();
                return result;

                //command.CommandText = "SELECT LastName FROM Employees Where EmployeeID = 5";
            }
            //connection.ConnectionString = CONNECTION_STRING;
        }

        static void Insert(string name, string phone)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = $"INSERT Shippers Values(@name, @phone)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phone);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Shipper created");
                }
                else { Console.WriteLine("fatal error"); }

                //command.CommandText = "SELECT LastName FROM Employees Where EmployeeID = 5";
            }
        }

        static List<Shipper> GetAllShippersConnected()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = $"SELECT * FROM Shippers";
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        List<Shipper> shippers = new List<Shipper>();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                shippers.Add(new Shipper()
                                {
                                    ShipperID = int.Parse(dr["ShipperId"].ToString()),
                                    CompanyName = dr["CompanyName"].ToString(),
                                    Phone = dr["Phone"].ToString(),
                                });
                            }
                        }
                        return shippers;
                    };

                    //command.CommandText = "SELECT LastName FROM Employees Where EmployeeID = 5";
                }
            }
        }
        static List<Shipper> GetAllShippersDisConnected()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = $"SELECT * FROM Shippers";
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    List<Shipper> shippers = new List<Shipper>();
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    connection.Close();

                    foreach (var item in dataTable.Columns)
                    {
                        Console.Write(item + " ");
                    }
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Console.WriteLine(item[0]);
                    }


                    return shippers;

                    //command.CommandText = "SELECT LastName FROM Employees Where EmployeeID = 5";
                }
            }
            static void DeleteShipper(int id)
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = $"DELETE FROM Shippers WHERE ShipperId = @id";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        Console.WriteLine("Shipper deleted");
                    }
                    else Console.WriteLine("fatal error");

                    //command.CommandText = "SELECT LastName FROM Employees Where EmployeeID = 5";
                }
            }

        }
    }
}