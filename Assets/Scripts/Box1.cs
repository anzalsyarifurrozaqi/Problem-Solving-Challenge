using UnityEngine;
using System.Collections;
using System;

public class Box1 : MonoBehaviour
{
    public Action SetNonActive;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Score.Instance.score += 1;
        }
    }
}