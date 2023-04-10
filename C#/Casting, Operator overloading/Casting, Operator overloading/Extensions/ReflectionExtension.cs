using Casting__Operator_overloading.Models;

namespace Casting__Operator_overloading.Extensions;

static class ReflectionExtension
{
    public static void ShowInfo(this Animal animal)
    {
        foreach (var item in animal.GetType().GetProperties())
        {
            Console.WriteLine(new String('-', 100));
            Console.WriteLine($"{item.Name} - {item.GetValue(animal)}");
        }
    }
}
