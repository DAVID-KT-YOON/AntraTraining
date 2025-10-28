namespace _02UnderstandingTypes;

public class _02UnderstandingTypes {
    static void Main()
    {
        Console.WriteLine("Type\tBytes\tMin Value\t\t\tMax Value");
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine($"sbyte\t{sizeof(sbyte)}\t{sbyte.MinValue}\t\t\t\t{sbyte.MaxValue}");
        Console.WriteLine($"byte\t{sizeof(byte)}\t{byte.MinValue}\t\t\t\t{byte.MaxValue}");
        Console.WriteLine($"short\t{sizeof(short)}\t{short.MinValue}\t\t\t\t{short.MaxValue}");
        Console.WriteLine($"ushort\t{sizeof(ushort)}\t{ushort.MinValue}\t\t\t\t{ushort.MaxValue}");
        Console.WriteLine($"int\t{sizeof(int)}\t{int.MinValue}\t\t\t{int.MaxValue}");
        Console.WriteLine($"uint\t{sizeof(uint)}\t{uint.MinValue}\t\t\t\t{uint.MaxValue}");
        Console.WriteLine($"long\t{sizeof(long)}\t{long.MinValue}\t\t{long.MaxValue}");
        Console.WriteLine($"ulong\t{sizeof(ulong)}\t{ulong.MinValue}\t\t\t\t{ulong.MaxValue}");
        Console.WriteLine($"float\t{sizeof(float)}\t{float.MinValue}\t\t\t{float.MaxValue}");
        Console.WriteLine($"double\t{sizeof(double)}\t{double.MinValue}\t{double.MaxValue}");
        Console.WriteLine($"decimal\t{sizeof(decimal)}\t{decimal.MinValue}\t{decimal.MaxValue}");
       
        
        Console.WriteLine("write how many centures");
        byte centuries = byte.Parse(Console.ReadLine());

        _02UnderstandingTypes instance = new _02UnderstandingTypes();
        instance.Question2(centuries);
        /*Test your Knowledge
         1. What happens when you divide an int variable by 0?
            -it will run into compile time error and not be able to run
         2. What happens when you divide a double variable by 0? 
            -positive double divided by 0 results in positive infinity whereas
            negative infinity results in negative double divided by 0.
            0.0/0 results in NaN (not a number)
         3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
            - unchecked overflow does not return Exception and carries on using two's complement on the bit representation
            of the number, which changes its value to either negative or positive depending on the arithmetic operation.
            In checked overflow, it will throw an Exception  
         4.What is the difference between x = y++; and x = ++y;?
            - ++ after variable name increments after its use.
            ++ before variable name increments first then uses the variable.
         5.What is the difference between break, continue, and return when used inside a loop
statement?
            - inside the loop, "break" breaks out of that current loop that break is called upon.
            "Continue" continues to the next iteration, and "return" stops the loop instantly and 
            returns the value out of the current method to the calling method.
            
         6. What are the three parts of a for statement and which of them are required?
            -parameters for the for loop are initialization, condition, and incremental value.
            all are optional in C# and if non is given, it is considered to be a infinite loop.
         7. What is the difference between the = and == operators?
            - = is an assignment of a value to the variable whereas == is a comparison operator.
         8.  Does the following statement compile? for ( ; true; ) ;
            it is valid and compiles. However in The Rider's app IDE says it is redundant and grays out the code as it does nothing.
         9. What does the underscore _ represent in a switch expression?
            -it is like default in Java switch. it matches with all unmatched input to the switch statement.
         10.What interface must an object implement to be enumerated over by using the foreach
statement?
            - object must have implemented IEnumerable interface to be a Collection that can be enumerated in order to use forEach Loop.
      
         */
    }

    private void Question2(byte centuries)
    {
        ushort years = (ushort)(centuries * 100);
        uint days = (uint)(years * 365);
        uint hours = days * 24;
        ulong minutes = hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        ulong nanoseconds = milliseconds * 1000;
        
        Console.WriteLine("Input: " + centuries);
        Console.WriteLine("Output: " + centuries + " centuries = " + years + " years = " 
                          + days + " days = " + hours + " hours = " + minutes + " minutes = " 
                          + milliseconds + " milliseconds = "  + nanoseconds + " nanoseconds" );
    }
    
    
}