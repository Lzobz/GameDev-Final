using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public static float remainingTime;
    [SerializeField] TextMeshProUGUI timerText;


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            remainingTime = 240f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        timerText.text = remainingTime.ToString("#,0");
        if (remainingTime < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
