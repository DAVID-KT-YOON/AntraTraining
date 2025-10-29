namespace Assignment02;

public class FIndPrime
{
    /*Write a method that calculates all prime numbers in given range and returns them as array
of integers
*/
    public int[] FindPrimesInRang(int startNum,int endNum)
    {
        List<int> numbers = new List<int>();
        for (int i = startNum; i < endNum; i++)
        {
            if (i == 0 || i == 1)
            {
                continue;
            }
            if (IsPrime(i))
            {
                numbers.Add(i);
            }
        }
        Console.WriteLine(string.Join(", ", numbers));
        return numbers.ToArray();
    }

    bool IsPrime(int num)
    {
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}