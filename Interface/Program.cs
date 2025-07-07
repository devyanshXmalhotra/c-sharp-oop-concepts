using System;
using System.Collections.Generic;

interface ISmartDevice
{
    string Brand { get; set; }           // Property
    void ConnectToWiFi();                // Method
    void ShowDeviceInfo();               // Method
}

class SmartPhone : ISmartDevice
{
    public string Brand { get; set; }

    public void ConnectToWiFi()
    {
        Console.WriteLine($"{Brand} Smartphone connected to WiFi.");
    }

    public void ShowDeviceInfo()
    {
        Console.WriteLine($"Device: Smartphone\nBrand: {Brand}");
    }
}

class SmartWatch : ISmartDevice
{
    public string Brand { get; set; }

    public void ConnectToWiFi()
    {
        Console.WriteLine($"{Brand} SmartWatch connected to WiFi.");
    }

    public void ShowDeviceInfo()
    {
        Console.WriteLine($"Device: SmartWatch\nBrand: {Brand}");
    }
}

class Program
{
    static void Main()
    {
        List<ISmartDevice> devices = new List<ISmartDevice>
        {
            new SmartPhone { Brand = "Samsung" },
            new SmartWatch { Brand = "Apple" }
        };

        foreach (ISmartDevice device in devices)
        {
            device.ShowDeviceInfo();
            device.ConnectToWiFi();
            Console.WriteLine("----------------------");
        }
    }
}
