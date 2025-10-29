namespace Assignment02;

public class MostRepeated
{
    public String CountRepeat(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]]++;
            }
        }
        int max = dict.Values.Max();
        foreach (KeyValuePair<int, int> pair in dict)
        {
            if (pair.Value == max)
            {
                list.Add(pair.Key);
            }
        }
        return (list.Count == 1)? $"The number {list[0]} is the most frequent (occurs {dict[list[0]]} times)" : $"The numbers {string.Join(", ", list)} have the same maximal frequence ( each occurs {dict[list[0]]} times). The leftmost of them is {list[0]}";
    }
}