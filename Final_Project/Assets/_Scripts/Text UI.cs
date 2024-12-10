using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class TextUI : MonoBehaviour
{

    [Header("Dynamic")]
    public TextMeshProUGUI uitLives;

    public static int lives = 3;
    // Start is called before the first frame update
     void Start()
    {
        uitLives = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (uitLives != null)
        {
            uitLives.text = lives.ToString("#,0");

        }
    }


}
