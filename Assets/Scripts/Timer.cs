using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer Instance
    {
        get
        {
            return _instance;
        }
    }

    private static Timer _instance;

    public float TimeFloat;
    public Text TimeText;
    private void Awake()
    {
        _instance = this;
    }
    private void Update()
    {
        TimeFloat -= 1f * Time.deltaTime;

        var m = TimeFloat / 60;
        var s = TimeFloat % 60;

        if (TimeFloat >= 0)
        {
            TimeText.text = $"{Mathf.Floor(m)} : {Mathf.Floor(s)}";
        }        
    }
}
