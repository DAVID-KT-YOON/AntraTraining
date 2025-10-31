namespace Assignment04;

public interface IRepository<T>
{
    //CRUD
    public void Add(T item);
    public T GetById(int id);
    public IEnumerable<T> GetAll();
    public void Save();
    public void Remove(T item);
}