namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            //Person person = new Person();

            //Eagle eagle = new Eagle();
            //Shark shark = new Shark();
            //shark.Eat();

            //Animal[] animal = { eagle, shark };

            //animal[0].Eat();
            //animal[1].Eat();

            //foreach (var item in animal)
            //{
            //    item.Eat();
            //    item.Live();
            //}

        }
    }

    #region Abstract



    //abstract class Animal
    //{
    //    public abstract void Eat();

    //    public virtual void Live()
    //    {
    //        Console.WriteLine("Live as animal");
    //    }
    //}

    //abstract class Bird : Animal
    //{




    //    class Eagle : Bird
    //    {
    //        public override void Eat()
    //        {
    //            Console.WriteLine("Eat as Eagle");
    //        }

    //        public void Fly()
    //        {
    //            throw new NotImplementedException();
    //        }

    //        public override void Live()
    //        {
    //            Console.WriteLine("Live as Eagle");
    //        }
    //    }

    //    abstract class Fish : Animal
    //    {
    //        public abstract void Swim();
    //        public override void Live()
    //        {
    //            Console.WriteLine("Fish");
    //        }
    //    }

    //    class Shark : Fish
    //    {
    //        public override void Eat()
    //        {
    //            Console.WriteLine("Eat as Shark");
    //        }

    //        public override void Swim()
    //        {
    //            Console.WriteLine("Swim as Shark");
    //        }

    //    } 
    //}
    #endregion

    #region Interface


    //interface ISum
    //{
    //    int Sum(int n1, int n2);
    //}
    //interface IDifference
    //{
    //    int Difference(int n1, int n2);
    //}

    //interface IMultiply
    //{
    //    int Multiply(int n1, int n2);
    //}
    //interface IDivide
    //{
    //    double Divide(double n1, double n2);
    //}

    //class Person : ISum
    //{
    //    public int Sum(int n1, int n2)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion

    #region Sealed
    //class Person
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Print");
    //    }
    //}
    //class Student : Person
    //{
    //    public sealed override void Print()
    //    {
    //        Console.WriteLine("");
    //    }
    //} 
    #endregion
}
