using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Timeofday : MonoBehaviour
{
   public static TextMeshProUGUI textClock;
    // Start is called before the first frame update
    void Start()
    {
       textClock = GetComponent<TextMeshProUGUI>();
       textClock.text = "Clock";
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        textClock.text = time.ToString("hh:mm:ss");
    }
}
