using UnityEngine;
using System.Collections;
using System;

public class Box : MonoBehaviour
{    
    public Action SetNonActive;

    public void SetActive()
    {
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SetNonActive();            
            Score.Instance.score += 1;
        }
    }
}