using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScaler : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    [Header("Inscribed")]
    public TextMeshProUGUI uitLevel;
    public int level;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        lives = 3;
>>>>>>> 79372bd16038b2f816645c4262c449200fe39889
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        float scale = Mathf.Lerp(minScale, maxScale, ((Mathf.Sin(Time.time * scaleSpeed) + 1) / 2));

        text.transform.localScale = Vector3.one * scale;

=======
        uitLevel.text = "Level: 1 of 4";
    
        if (balloon.ballooncnt > 11)
        {
            SceneManager.LoadScene("Test Scene");

            uitLevel.text = "Level: 2 of 4";

        }
>>>>>>> 79372bd16038b2f816645c4262c449200fe39889
    }
}
