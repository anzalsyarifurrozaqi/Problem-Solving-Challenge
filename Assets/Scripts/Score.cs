using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance
    {
        get
        {            
            return _instance;
        }
    }

    private static Score _instance;

    public Text text;
    public int score;

    private void Awake()
    {
        _instance = this;
    }
    void Update()
    {
        text.text = $"Score : {score}";
    }
}
