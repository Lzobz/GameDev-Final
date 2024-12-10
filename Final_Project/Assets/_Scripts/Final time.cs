using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Finaltime : MonoBehaviour
{
    [Header("Dynamic")]
    private TextMeshProUGUI uifinaltime;
    // Start is called before the first frame update
    void Start()
    {
        uifinaltime = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        uifinaltime.text = Timer.finaltime.ToString("#,0");
    }

}
