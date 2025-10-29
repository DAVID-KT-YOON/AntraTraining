// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");

/*Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
    -String is immutable and stringbuilder object is mutable. Therefore, String should be used when the
    String's value does not need to change frequently and stringbuilder should be used when the value of
    the string has to be altered throughout the program.
2. What is the base class for all arrays in C#?
    - System.Array is the base class for all arrays in C#
3. How do you sort an array in C#?
    - you can sort using Array.sort(array arr). They have the time complexity of O(nlogn) thus 
    no custom sort would be necessary.
4. What property of an array object can be used to get the total number of elements in
an array?
    - The length property returns the total number of elements in an array.
5. Can you store multiple data types in System.Array?
    - Only if it is the array of objects. since object is the base class of all types, object array will be able to
    contain various types when boxed.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    - copyTo does not create new array but clone does. copyTo requires destination array to be copied to but clone 
    returns object array that needs to be casted.
*/
/*
Practice Arrays
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly.*/
int[] arr = { 1, 5, 2, 8, 5, 4, 3, 4, 1, 6 };
int[] arr2 = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    arr2[i] = arr[i];
    Console.WriteLine(arr[i]);
    Console.WriteLine(arr2[i]);
}

/*Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear. The syntax should be as follows:*/
String[] strArr = new string[10];
byte size = 0; 
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
String command = Console.ReadLine();
if (command.StartsWith("+"))
{
    strArr[size++] = command.Substring(1, command.Length - 1).Trim();
}
else if (command.StartsWith("--"))
{
    size = 0;
    strArr = new String[strArr.Length];
}
else if (command.StartsWith("-"))
{
    for (int i = 0; i < size; i++)
    {
        
        if (strArr[i].Equals(command.Substring(1, command.Length - 1).Trim()))
        {
            for (int j = i + 1; j < strArr.Length; j++)
            {
                strArr[j - 1] = strArr[j];
            }
            size--;
            break;
        }
    }
}

for (int i = 0; i < size; i++)
{
    Console.WriteLine(strArr[i]);
}
