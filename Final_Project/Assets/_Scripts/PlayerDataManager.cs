using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    //Keys for player prefs
    private const string uniqueID_key = "UniquePlayerID";
    private const string time_key = "TimePlayed";
    private const string duration_key = "DurationPlayed";
    private const string score_key = "PlayerScore";
    private const string feedback_key = "PlayerFeedback";

    void Start()
    {
        //Check for unique ID
        string uniqueID = CheckUniqueID();
        Debug.Log("Player Unique ID: " + uniqueID);
    }

    private string CheckUniqueID()
    {
        //Checks for unique ID
        if (!PlayerPrefs.HasKey(uniqueID_key)) { 
            //generates new ID
            string newUniqueID = Guid.NewGuid().ToString();
            PlayerPrefs.SetString(uniqueID_key, newUniqueID);
            PlayerPrefs.Save();
        }

        return PlayerPrefs.GetString(uniqueID_key);
    }

}
