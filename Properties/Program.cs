class Person
{
    //private string name;

    //public string Name
    //{
    //    get { return name; } 
    //    set { name = value; } 
    //}

// using auto implemented properties
    public string name { get; set; }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Devyansh"; 
        Console.WriteLine(p.Name); 
    }
}
