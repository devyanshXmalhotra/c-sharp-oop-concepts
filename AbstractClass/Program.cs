abstract class Animal
{
    public abstract void MakeSound(); 
    public void Sleep()              
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
