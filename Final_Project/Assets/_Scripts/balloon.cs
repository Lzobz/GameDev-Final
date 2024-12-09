using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balloon : MonoBehaviour
{
    private Camera cam;
    public static int ballooncnt = 1;

    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {
      
        //if (balloon.ballooncnt > 23 && balloon.ballooncnt <36)
        //{
        //    SceneManager.LoadScene("Level3");
        //}
        //if (balloon.ballooncnt > 35)
        //{
        //    SceneManager.LoadScene("Level4");
        //}
        //if (balloon.ballooncnt > 47)
        //{
        //    SceneManager.LoadScene("EndScreen");
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Balloon Count: " + ballooncnt.ToString());
            Destroy(this.gameObject);
            ballooncnt++;
            ScoreCounter.score += 50;
        }
        //if (ballooncnt == 12)
        //{
        //    Debug.Log("Lvl 2");
        //    SceneManager.LoadScene("Level2");
        //    ballooncnt++;
        //}
        //if (ballooncnt > 23 && ballooncnt < 25)
        //{
        //    SceneManager.LoadScene("Level3");
        //    ballooncnt++;
        //}
        //if (ballooncnt == 36)
        //{
        //    SceneManager.LoadScene("Level4");
        //    ballooncnt++;
        //}
        //if (ballooncnt > 47)
        //{
        //    SceneManager.LoadScene("EndScreen");
        //}

    }
}
