using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public static int score = 0;
    private TextMeshProUGUI uiscore;
    // Start is called before the first frame update
    void Start()
    {
        uiscore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        uiscore.text = score.ToString("#,0");
    }


}
