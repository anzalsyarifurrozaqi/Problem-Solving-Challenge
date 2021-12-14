using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{  
    [SerializeField] ObjectPool2 pool;
    [SerializeField] GameObject prefab;

    private IObjectPool _objectPooler;

    void Start()
    {
        _objectPooler = pool;
        int size = UnityEngine.Random.Range(5, 10);
        _objectPooler.CreatePool(prefab, size);

        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        _objectPooler.SpawnFromPool();        
        yield return new WaitForSeconds(3f);
        StartCoroutine(SpawnObject());
    }
}
