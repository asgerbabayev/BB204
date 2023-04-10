using Casting__Operator_overloading.Interfaces;

namespace Casting__Operator_overloading.Models;

internal class Eagle : Bird, IFly
{
    public int Age { get; set; }
    public override void Eat()
    {
        Console.WriteLine("Eat as Eagle");
    }
    public void Fly()
    {
        Console.WriteLine("Fly as Eagle");
    }
}
