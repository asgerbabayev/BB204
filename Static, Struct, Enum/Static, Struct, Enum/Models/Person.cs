namespace Static__Struct__Enum.Models;

internal class Person
{

    #region Static members
    private static int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public static string Name { get; set; }
    public string Surname { get; set; }
    public static int Count { get; set; }

    static Person()
    {
        Count = 0;
    }

    public Person()
    {
        Id++;
        Count++;
    }



    #endregion
}
