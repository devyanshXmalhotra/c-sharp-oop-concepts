//class Person
//{
//    public string Name { get; set; }

//    public void Introduce()
//    {
//        Console.WriteLine($"Hi, I'm {Name}.");
//    }
//}

//class Student : Person
//{
//    public string School { get; set; }

//    public void Study()
//    {
//        Console.WriteLine($"{Name} passed out from {School}.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s = new Student();
//        s.Name = "Devyansh";
//        s.School = "PIET";

//        s.Introduce(); 
//        s.Study();     
//    }
//}

class Employee
{
    public string Name { get; set; }
    public int Salary{ get; set; }

    public void DisplayInfo(string Name, int Salary)
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public string Department { get; set; }
    public void DisplayManagerInfo()
    {
        Console.WriteLine($"Manager of {Department} department.");
    }
}


class Problem
{
    static void Main(string[] args)
    {
        Manager mng= new Manager();

        mng.Name="Devyansh";
        mng.Salary= 50000;
        mng.Department = "IT";
        mng.DisplayInfo(mng.Name, mng.Salary);
        mng.DisplayManagerInfo();
    }
}