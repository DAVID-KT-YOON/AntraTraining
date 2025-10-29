namespace Assignment02;

public class RotationArray
{
 public int[] ReadAndCalculate(int[] arr, int k)
 {
  int[] newarr = new int[arr.Length];

  for (int i = 0; i < arr.Length; i++)
  {
   newarr[(i + k) % arr.Length] = arr[i];
  }

  for (int i = 0; i < arr.Length; i++)
  {
   arr[i] += newarr[i];
  }

  return arr;

 }   
}