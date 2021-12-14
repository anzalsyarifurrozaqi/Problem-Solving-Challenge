using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectPool
{
    void CreatePool(GameObject prefab, int size);
    GameObject SpawnFromPool();
    void DespawnToPool(GameObject gameObject);
}
