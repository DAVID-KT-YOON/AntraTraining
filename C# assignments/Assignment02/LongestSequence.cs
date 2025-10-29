namespace Assignment02;

public class LongestSequence
{
    public int[] LongestSeq(int[] arr)
    {
        int currLen = 0;
        int currStart = 1;
        int bestLen = -1;
        int bestStart = -1;
        if (arr == null || arr.Length == 0)
        {
            return arr;
        }
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i -1].Equals(arr[i]))
            {
                currLen++;
            }
            else
            {
                if (bestLen < currLen)
                {
                    bestLen = currLen;
                    bestStart = currStart;
                }

                currStart = i;
                currLen = 1;
            }
            
        }

        if (currLen > bestLen)
        {
            bestLen = currLen;
            bestStart = currStart;
            
        }

        int[] newarr = new int[bestLen];
        Array.Copy(arr, bestStart, newarr, 0, bestLen);
        return newarr;
    }
}