using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldBalloon : MonoBehaviour
{
    public string Level2;
    public string Level3;
    public string Level4;
    public string EndScreen;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && sceneName == "Level1")
        {

            ScoreCounter.score += 100;
            SceneManager.LoadScene(Level2);
        }

        if (other.gameObject.tag == "Player" && sceneName == "Level2")
        {

            ScoreCounter.score += 100;
            SceneManager.LoadScene(Level3);
        }

        if (other.gameObject.tag == "Player" && sceneName == "Level3")
        {

            ScoreCounter.score += 100;
            SceneManager.LoadScene(Level4);
        }
        if (other.gameObject.tag == "Player" && sceneName == "Level4")
        {

            ScoreCounter.score += 100;
            SceneManager.LoadScene(EndScreen);
        }
    }
}

