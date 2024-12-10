using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPref : MonoBehaviour
{
    public TMP_InputField inputFd;
    public TMP_InputField Feedback;
    // Start is called before the first frame update
   public void SaveData()
    {
        PlayerPrefs.SetString("Input", inputFd.text);
        PlayerPrefs.SetInt("Player Score", ScoreCounter.score);
        PlayerPrefs.SetString("Feedback", Feedback.text);
        PlayerPrefs.SetFloat("Time Taken", Timer.finaltime);
        PlayerPrefs.SetString("Time of day", Timeofday.textClock.text);

    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Input");
    }
}
