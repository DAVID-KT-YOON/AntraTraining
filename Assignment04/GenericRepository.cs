namespace Assignment04;

public class GenericRepository<T>:IRepository<T> where T : Entity
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return list;
    }

    public T GetById(int id)
    {
        foreach (T item in list)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}