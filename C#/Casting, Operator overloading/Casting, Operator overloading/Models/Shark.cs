namespace Casting__Operator_overloading.Models;

internal class Shark : Fish
{
    public bool SleepMode { get; set; }
    public override void Eat()
    {
        Console.WriteLine("Eat as Shark");
    }

    public override void Swim()
    {
        Console.WriteLine("Swim as Shark");
    }
}
