using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool
{
    public List<GameObject> pooledObjects = new List<GameObject>();
    public int maxCount;

    private GameObject objectToPool;

    public GameObjectPool(GameObject _objectToPool, int _maxCount)
    {
        // set variables
        this.objectToPool = _objectToPool;
        this.maxCount = _maxCount;

        // instantiate all the objects
        CreateObjects();
    }

    private void CreateObjects()
    {
        for (int i = 0; i < maxCount; i++)
        {
            GameObject newObj = GameObject.Instantiate(objectToPool);
            newObj.SetActive(false);
            pooledObjects.Add(newObj);
        }
    }

    public GameObject AcquireObject()
    {
        // check if there is something in the pool
        if(pooledObjects.Count <= 0) 
        {
            Debug.LogWarning("[GameObjectPool] Pool for " + objectToPool.name + " returned null, no " + objectToPool.name + " available. Release some first");
            return null;
        }

        GameObject newObj = pooledObjects[pooledObjects.Count - 1];
        pooledObjects.Remove(newObj);
        return newObj;
    }

    public void ReleaseObject(GameObject obj) 
    {
        // If time allows - Check if given object fits in this pool
        // if yes,
        pooledObjects.Add(obj);
        // if no,
        //Debug.LogWarning("[GameObjectPool] " + obj.name + "can not be released into " + objectToPool.name + " pool");
    }
}
