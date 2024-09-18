public class GenericPoolObject<T>
{
    public bool inUse = false;
    public T obj;

    public GenericPoolObject(T _obj)
    {
        this.obj = _obj;
    }

    public void SetActive()
    {
        inUse = true;
    }

    public void SetInactive()
    {
        inUse = false;
    }
}
