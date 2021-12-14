using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool2 : MonoBehaviour, IObjectPool
{

    private List<GameObject> _objList;
    private GameObject _prefab;

    public void CreatePool(GameObject prefab, int size)
    {        
        _objList = new List<GameObject>();
        _prefab = prefab;

        for (int i = 0; i < size; i++)
        {
            GameObject gameObject = Instantiate(prefab);

            var x = Random.Range(0f, Screen.width);
            var y = Random.Range(0f, Screen.height);

            Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0f));
            position.z = 0f;
            gameObject.transform.position = position;

            Box box = gameObject.GetComponent<Box>();
            if (box != null)
                box.SetNonActive = () => {
                    DespawnToPool(gameObject);
                };

            _objList.Add(gameObject);
        }
    }

    public void DespawnToPool(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public GameObject SpawnFromPool()
    {        
        GameObject obj = _objList.Find(o => !o.activeSelf);

        if (obj == null)
        {            
            return null;
        }

        var x = Random.Range(0f, Screen.width);
        var y = Random.Range(0f, Screen.height);

        Vector3 position = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0f));
        position.z = 0f;
        obj.transform.position = position;

        Box box = obj.GetComponent<Box>();
        if (box != null) box.SetActive();

        return obj;
    }
}
