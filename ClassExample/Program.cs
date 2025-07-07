using System;

class Car
{
    public string Brand;
    public int Speed;

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Brand = "Suzuki Brezza";
        myCar.Speed = 120;
        myCar.Drive();
    }
    
}