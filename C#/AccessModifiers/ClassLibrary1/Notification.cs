namespace ClassLibrary1;

public class Notification
{
    protected internal string Title { get; set; }
    private protected string Description { get; set; }


    public Notification()
    {
        Title = "";
    }

}

public class Message : Notification
{
    public Message()
    {
        Description = "";
    }
}
