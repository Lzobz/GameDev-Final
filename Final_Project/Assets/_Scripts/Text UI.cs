using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUI : MonoBehaviour
{

    [Header("Inscribed")]
    public TextMeshProUGUI uitLevel;
    public int level;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {

        uitLevel.text = "Level: 1 of 4";
    
        if (balloon.ballooncnt > 11)
        {
            SceneManager.LoadScene("Test Scene");

            uitLevel.text = "Level: 2 of 4";

        }
    }
}
