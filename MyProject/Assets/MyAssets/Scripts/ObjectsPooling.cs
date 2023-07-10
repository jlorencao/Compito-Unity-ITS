using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPooling : MonoBehaviour
{
    [SerializeField] public ObjectPoolItem[] itemsToPool;

    private List<GameObject> pooledObjects;

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();

        
    }

   /* public GameObject GetPooledObjects(string name) 
    {
        for (int i = 0; i > pooledObjects.Count; i++)
        {
            if (pooledObjects[i].activeInHierarchy == false && pooledObjects[i].name == name)
            return pooledObjects[i];

        }
        foreach (ObjectPoolItem item in itemsToPool)
        {
            if (item.poolObject.name == name)
            {
            for(int i = 0; i < item.poolAmount; i++)
            {
                GameObject obj = Instantiate(item.poolObject);
                obj.name = item.name;
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
            }
        }
    }*/
    
}

[System.Serializable]
public class ObjectPoolItem 
{
    public string name;
    public int poolAmount;
    public GameObject poolObject;
    public bool shouldExpand;
}