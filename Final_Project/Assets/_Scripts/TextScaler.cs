using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScaler : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float scaleSpeed = 2f;
    public float minScale = 1.0f;
    public float maxScale = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (text == null)
        {
            text = GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float scale = Mathf.Lerp(minScale, maxScale, ((Mathf.Sin(Time.time * scaleSpeed) + 1) / 2));

        text.transform.localScale = Vector3.one * scale;
    }
}
