using Casting__Operator_overloading.Extensions;
using Casting__Operator_overloading.Models;

namespace Casting__Operator_overloading;

internal class Program
{
    static void Main(string[] args)
    {
        #region Casting
        #region Upcasting, implicit, boxing

        //Animal eagle = new Eagle();
        //eagle.Eat();
        //Console.WriteLine(eagle.GetType());
        //Shark shark = new Shark();
        //Animal animal = shark;
        #endregion

        #region Downcasting, explicit, unboxing
        //Eagle eagle = new Eagle();
        //Shark shark = new Shark();

        //Animal animal = shark;
        //Console.WriteLine(animal.GetType());

        //Non secure
        //Eagle eagle1 = (Eagle)animal;

        //Downcasting secure way
        //pattern matching
        //if (animal is Eagle e)
        //{
        //    e.Fly();
        //    //Eagle eagle1 = (Eagle)animal;
        //}
        //else
        //{
        //    Console.WriteLine("Akula uca bilmez");
        //}

        //Eagle eagle2 = animal as Eagle;
        //if (eagle2 != null)
        //{

        //}

        //int number = 5;
        //bool isValid = false;

        //Object[] arr = { eagle, shark, number, isValid };

        #endregion
        #endregion

        #region Implicit and explicit operators

        //Manat manat = new Manat(2);
        //Dollar dollar = manat;
        //Console.WriteLine(dollar.Usd);

        //Dollar dollar = new(1000);
        //Manat manat = dollar;
        //Console.WriteLine(manat.Azn);
        #endregion

        #region Operator Overloading

        //Person person1 = new Person();
        //person1.Age = 20;
        //Person person2 = new Person();
        //person2.Age = 20;

        ////if (person1.Age == person2.Age)

        //Console.WriteLine(person1 == person2); 
        #endregion

        Eagle eagle = new Eagle();
        eagle.Age = 20;
        Animal animal = eagle;



        Shark shark = new Shark();
        shark.SleepMode = true;


        animal = shark;

        animal.ShowInfo();

    }
}

#region Implicit explicit operators

class Manat
{
    public double Azn { get; set; }
    public Manat(double azn)
    {
        Azn = azn;
    }

    public static implicit operator Dollar(Manat manat)
    {
        return new Dollar(manat.Azn / 1.7);
    }

    //public static explicit operator Dollar(Manat manat)
    //{
    //    return new Dollar(manat.Azn / 1.7);
    //}

}

class Dollar
{
    public double Usd { get; set; }
    public Dollar(double usd)
    {
        Usd = usd;
    }
    public static implicit operator Manat(Dollar dollar)
    {
        return new Manat(dollar.Usd * 1.7);
    }
}
#endregion

#region Operator Overloading
class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }


    public static bool operator >=(Person p1, Person p2)
    {
        return p1.Age >= p2.Age;
    }
    public static bool operator <=(Person p1, Person p2)
    {
        return p1.Age <= p2.Age;
    }
    public static bool operator >(Person p1, Person p2)
    {
        return p1.Age > p2.Age;
    }
    public static bool operator <(Person p1, Person p2)
    {
        return p1.Age < p2.Age;
    }

    public static bool operator ==(Person p1, Person p2)
    {
        return p1.Age != p2.Age;
    }

    public static bool operator !=(Person p1, Person p2)
    {
        return p1.Age != p2.Age;
    }
}
#endregion


