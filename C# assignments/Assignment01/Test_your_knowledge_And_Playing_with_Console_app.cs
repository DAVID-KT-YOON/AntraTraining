namespace ConsoleApp1;

public class Assignment01
{
    //1. What type would you choose for the following "numbers"?
    // private short telephone;
    // private byte height;
    // private byte age;
    // private byte gender;
    // private int salary;
    // private int ISBN;
    // private int price;
    // private short weight;
    // private long population;
    // private long stars_in_universe;
    // private int num_small_medium_business_employees;
    
    // 2. What are the difference between value type and reference type variables? What is
    // boxing and unboxing?
    /* value type is the value that is stored in stack itself where as reference type is stored in heap
     and the address of the reference type is stored in the stack. boxing is when you encapsulate a value type variable into an object
     making it a reference type, and unboxing is turning reference type object into value type variable.*/
    
    // 3.What is meant by the terms managed resource and unmanaged resource in .NET
    /* managed resources are the objects that are handled automatically by the garabage collector in the managed heap.
     The garbage collector will delete them as needed after few checks over time when there is no code that uses those resources
     in order to have memory preservations. 
     The unmanaged resources are the resources that are not managed by clr of .NET and the garbage collector does not handle them.
     These include files that are open through filestreams, databases that are open and etc. that must be closed by the code otherwise
     memory leaks happen.*/
    
    //4. Whats the purpose of Garbage Collector in .NET?
    /* .NET is responsible for memory management of the program.
     The garbage collector in .NET cleans the unused memory resources
     so that the memory can be preserved and used for other processes.*/
    
    // Playing with Console App
    public static void Main(String[] args)
    {
     int streetNumber = -1;
     //using just readline and writeline to generate hacker name
     Console.WriteLine("Lets create a Hacker name for you");
     Console.WriteLine("please enter your favorite color");
     String color = Console.ReadLine();
     Console.WriteLine("please enter your astrology sign");
     String astrologySign = Console.ReadLine();
     Console.WriteLine("please enter your street address number");
     while (true)
     {
      try
      {
       
       streetNumber = int.Parse(Console.ReadLine());
       break;
      }
      catch (Exception e)
      {
       Console.WriteLine("Please write numbers only for the street address number");
      }
     }
     Console.WriteLine($"your Hacker name is {color}{astrologySign}{streetNumber}");
    }
    
}
