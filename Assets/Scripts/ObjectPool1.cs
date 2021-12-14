using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool1 : MonoBehaviour, IObjectPool
{

    private List<GameObject> _objList;
    private GameObject _prefab;    

    public void CreatePool(GameObject prefab, int size)
    {
        // Create Pool and Instantiate All Objects
        _objList = new List<GameObject>();        
        _prefab = prefab;

        for (int i = 0; i < size; i++)
        {
            GameObject gameObject = Instantiate(prefab);

            var x = UnityEngine.Random.Range(0f, Screen.width);
            var y = UnityEngine.Random.Range(0f, Screen.height);

            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0f));
            position.z = 0f;
            gameObject.transform.position = position;

            _objList.Add(gameObject);
        }
    }

    public void DespawnToPool(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    public GameObject SpawnFromPool()
    {
        throw new System.NotImplementedException();
    }
}
