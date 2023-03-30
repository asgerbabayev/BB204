namespace Class_Practise.Models;

internal class Car : Vehicle
{
    public string brand;
    public string model;
    public double fuelCapacity;
    public double fuelFor1Km;
    public double currentFuel;

    public Car(string model, string brand, double fuelFor1km, double fuelCapacity, int year) : base(year)
    {
        this.model = model;
        this.brand = brand;
        this.fuelCapacity = fuelCapacity;
        this.fuelFor1Km = fuelFor1km;
    }
    public Car(string model, string brand, double fuelFor1km, double fuelCapacity, int year, string color)
      : this(model, brand, fuelFor1km, fuelCapacity, year)
    {
        base.color = color;
    }
}
