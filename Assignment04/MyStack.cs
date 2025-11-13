namespace Assignment04;

public class MyStack<T>
{
   private List<T> list = new List<T>();

   public int Count()
   {
      return list.Count;
   }

   public T Pop()
   {
      T value = list[list.Count - 1];
      list.RemoveAt(list.Count - 1);
      return value;
   }

   public void Push(T item)
   {
      list.Add(item);
   }
   
}