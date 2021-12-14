using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    [SerializeField] ObjectPool1 pool;
    [SerializeField] GameObject prefab;    

    private IObjectPool _objectPooler;

    void Start()
    {
        _objectPooler = pool;
        int size = UnityEngine.Random.Range(1, 10);
        _objectPooler.CreatePool(prefab, size);
    }
}
