using AccessModifiers.Models;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Public - class,(interface), class members(fields,methods,properties,nested class)
            //Car car = new Car();
            //car.Brand = "brand";
            //car.Run();
            #endregion

            #region Protected - class members(fields,methods,properties,nested class)
            //Car car = new Car();
            //car.Year = "";
            //Console.WriteLine(car.Year);
            #endregion

            #region Internal - class, class members
            //Car car = new Car();
            //car.Color = "red";
            //Console.WriteLine(car.Color);
            #endregion

            #region Private class members
            //Car car = new Car();
            //car._speed = 15;
            //Car car = new Car();
            //var result = typeof(Car).GetField("_speed", System.Reflection.BindingFlags.NonPublic |
            //      System.Reflection.BindingFlags.Instance).GetValue(car);
            //Console.WriteLine(result);
            #endregion

            #region Encapsulation
            //Car car1 = new Car();
            //car1.SetSpeed(-50);
            ////car1.SetSpeed(-300);
            //Console.WriteLine(car1.GetSpeed());
            //car1.Speed = 100;
            ////car1._speed = -100;

            //Console.WriteLine(car1.Speed); 
            #endregion

            #region Readonly fields and properties
            //Car car = new Car();
            //Console.WriteLine(car.MyProperty);
            //car.MyProperty = 5; 
            #endregion

            #region Namespaces
            //M.Car car = new M.Car();
            //Car car1 = new Car();
            //car1.Test = 5; 
            #endregion

            #region Tuple
            //Car car = new Car();
            //var result = car.CheckUsername("ferid");

            //// ternary operator
            //var isValid = result.isValid ? result.message : result.message;
            //Console.WriteLine(isValid);
            #endregion

            //Notification notification = new Notification();


            Car car = new Car();
            car.Brand = "sada";
            car.Model = "sada";

            Console.WriteLine(car.Brand);


        }
    }
    //class Car : Notification
    //{
    //    public Car()
    //    {
    //        Title = "";
    //    }
    //    public int Test { get; set; }
    //}
}