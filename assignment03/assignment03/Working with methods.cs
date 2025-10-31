namespace assignment03;

public class Working_with_methods
{
    private static readonly Random random = new Random();
    public int[] GenerateNumbers()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
          numbers[i] = random.Next();  
        }
        return numbers;
    }
    public int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            numbers[i] = random.Next();  
        }
        return numbers;
    }

    public void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    public int[] Reverse(int[] numbers)
    {
        int x = 0;
        int[] retVal = new int[numbers.Length];
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            retVal[x++] = numbers[i];
        }
        return retVal;
    }

    public int[] ReverseWithSwap(int[] numbers)
    {
        int temp = 0;
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }

        return numbers;
    }

    public int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        
    }
}