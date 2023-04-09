namespace AccessModifiers.Models;
//public record Car1(int id, string uname);
public class Car
{
    public string Brand;
    public string Model;
    protected int Year;
    //public string Color { get; private set; }

    //private const string _color = "";
    private readonly string _color;
    public int MyProperty { get; }

    #region Encapsulation
    private int _speed;
    public int Speed
    {
        get
        {
            if (_speed != 0)
            {
                return _speed;
            }
            return -1;
        }
        set
        {
            if (value >= 20)
            {
                _speed = value;
                return;
            }
            Console.WriteLine("You was set wrong speed");
        }
    }
    #endregion


    //public Car()
    //{
    //    MyProperty = 15;
    //    _color = "";
    //}

    //public Car(int speed)
    //{
    //    Speed = speed;
    //}

    //public void Run()
    //{
    //    //MyProperty = 45;
    //    //_color = "";
    //    _speed = 30;
    //    Console.WriteLine(_speed);
    //    Console.WriteLine("Rus as a car");
    //}

    #region Tuple
    //public (string message, bool isValid) CheckUsername(string username)
    //{
    //    if (!string.IsNullOrEmpty(username))
    //    {
    //        return (username, true);
    //    }
    //    return ("Wrong username", false);
    //}
    #endregion

    #region Custom encapsulation
    //public void SetSpeed(int speed)
    //{
    //    if (speed >= 20)
    //    {
    //        _speed = speed;
    //        return;
    //    }
    //    Console.WriteLine("You was set wrong speed");
    //}

    //public int GetSpeed()
    //{
    //    if (_speed != 0)
    //    {
    //        return _speed;
    //    }
    //    return -1;
    //} 
    #endregion




    public string ShowInfo()
    {
        return Brand + " " + Model;
    }
    public override string ToString()
    {
        return ShowInfo();
    }

}
