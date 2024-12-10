using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextUI : MonoBehaviour
{

    [Header("Inscribed")]
    public TextMeshProUGUI uitLives;

    public int lives;
    // Start is called before the first frame update
     void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (uitLives != null)
        {
            uitLives.text = "Lives: " + (lives);

        }
    }


}
