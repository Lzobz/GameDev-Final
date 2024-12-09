using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balloon : MonoBehaviour
{
    private Camera cam;
    public static int ballooncnt;

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
            Destroy(this.gameObject);
            ballooncnt++;
        }
        if (balloon.ballooncnt > 11 && balloon.ballooncnt<13)
        {
            SceneManager.LoadScene("Level2");
        }
        if (balloon.ballooncnt > 23 && balloon.ballooncnt < 25)
        {
            SceneManager.LoadScene("Level3");
        }
        if (balloon.ballooncnt > 35 && balloon.ballooncnt < 37)
        {
            SceneManager.LoadScene("Level4");
        }
        if ( balloon.ballooncnt > 47)
        {
            SceneManager.LoadScene("EndScreen");
        }

    }
}
