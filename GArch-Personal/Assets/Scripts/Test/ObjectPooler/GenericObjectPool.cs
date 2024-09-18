using System.Collections.Generic;
using UnityEngine;

public class GenericObjectPool<T> where T : class
{
    private int poolSize;
    List<GenericPoolObject<T>> pooledObjects;

    public GenericObjectPool(int _poolSize)
    {
        poolSize = _poolSize;
        pooledObjects = new List<GenericPoolObject<T>>();
    }

    public void CreateObjects()
    {
        for (int i = 0; i < poolSize; i++)
        {
            //pooledObjects.Add(new PoolObject<T>());
        }
    }

    public GenericPoolObject<T> GetObject()
    {
        foreach (GenericPoolObject<T> obj in pooledObjects)
        {
            if (obj.inUse == false)
            {
                return obj;
            }
        }

        Debug.LogWarning("[ObjectPooler] Could not find an inactive object within pool");
        return null;
    }

    public void ReleaseObject(GenericPoolObject<T> _obj)
    {
        GenericPoolObject<T> currentObj = pooledObjects.Find(x => x == _obj);

        if (currentObj.inUse == true) { currentObj.inUse = false; }
    }
}
