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
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            ballooncnt++;
        }

        
    }
}
