using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool poolscr; //избавится от паттерна сингл
    public GameObject Parent;
    public List<GameObject> GOSet = new List<GameObject>();
    private List<List<GameObject>> pooledGO = new List<List<GameObject>>();
    const int nomPool_int = 0;
    GameObject object_go;

    public GameObject GetPool()
    {
        GetPooledObject();
        if (GetPooledObject() == null)
        {
            Debug.Log("New_Object " + nomPool_int);
            object_go = PoolInstans();
            pooledGO[nomPool_int].Add(object_go);
            return object_go;
        }
        else
        {
            Debug.Log("GetPooled");
            return GetPooledObject();
        }
    }
    void Awake()
    {
        poolscr = this;

    }
    void Start()
    {
        PoolStart();
    }
    void PoolStart()
    {
        for (int i = 0; i < GOSet.Count; i++)
        {
            pooledGO.Add(new List<GameObject>());
        }
    }
    GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledGO[nomPool_int].Count; i++)
        {
            if (!pooledGO[nomPool_int][i].activeInHierarchy)
            {
                return pooledGO[nomPool_int][i];
            }
        }
        return null;
    }
    GameObject PoolInstans()
    {
        object_go = Instantiate(GOSet[nomPool_int]);
        //Deactivate(object_go);
        return object_go;
    }
}
