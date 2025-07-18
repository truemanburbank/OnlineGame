using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager 
{
    // Dictionary<int, GameObject> _objects = new Dictionary<int, GameObject>();
    List<GameObject> _objects = new List<GameObject>();

    public void Add(GameObject go)
    {
        _objects.Add(go);
    }

    public void Remove(GameObject go)
    {
        _objects.Remove(go);
    }

    // 해당 좌표에 creature가 있는지
    public GameObject Find(Vector3Int cellPos)
    {
        foreach (GameObject obj in _objects)
        {
            CreatureController cc = obj.GetComponent<CreatureController>();
            if (cc == null)
                continue;

            if(cc.CellPos == cellPos)
                return obj;
        }

        return null;
    }

    public GameObject Find(Func<GameObject, bool> condition)
    {
        foreach (GameObject obj in _objects)
        {
            if (condition.Invoke(obj))
                return obj;
        }

        return null;
    }

    public void Clear()
    {
        _objects.Clear();
    }
}
