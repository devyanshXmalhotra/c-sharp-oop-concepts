using System;

class Calculator
{
    public static int Count = 0;

    public static int Add(int a, int b) 
    {
        Count++;
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        int result = Calculator.Add(5, 3); 
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Add method called {Calculator.Count} times.");
    }
}
