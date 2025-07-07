using System;


class Car
{
    public string brand;
    public int speed;

    public Car(string carBrand, int carSpeed)
    {
        brand = carBrand;
        speed = carSpeed;
        Console.WriteLine($"Car created: {brand} with speed {speed} km/h");
    }
    public void Drive()
    {
               Console.WriteLine($"{brand} is driving at {speed} km/h");
    }
    ~Car()
    {
        Console.WriteLine($"Car {brand} is being destroyed");
    }
}


class Program
{
    static void Main(string[] args)
    {
        string b=Console.ReadLine();
        int s = int.Parse(Console.ReadLine());
        Car myCar = new Car(b,s);
        myCar.Drive();
        myCar = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}