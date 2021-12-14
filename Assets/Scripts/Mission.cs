using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public int MissionScoreCount;
    public Text MissionText;
    public GameObject ResultObj;
    public Text ResultText;

    private static string _berhasil = "BERHASIL !!!";
    private static string _gagal = "GAGAL !!!";
    private string _resultText;
    private bool isEnd = false;
    private void Start()
    {
        MissionText.text = $"Misi kumpulkan {MissionScoreCount} kotak hitam";
    }
    private void Update()
    {
        if (isEnd)
        {
            ShowResult();

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            return;
        }

        if (Timer.Instance.TimeFloat < 0)
        {
            _resultText = _gagal;
            isEnd = true;
        }

        if (Score.Instance.score >= MissionScoreCount)
        {
            _resultText = _berhasil;
            isEnd = true;
        }
    }
    
    private void ShowResult()
    {
        ResultText.text = _resultText + "\n Tap untuk coba lagi";
        ResultObj.SetActive(true);
    }
}
