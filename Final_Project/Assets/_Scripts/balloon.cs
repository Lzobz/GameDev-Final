using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        /*Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        { 

            if (raycastHit.collider.name == "balloon")
            {
                Destroy(this.gameObject);
            }

        }
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
            Debug.DrawLine(ray.origin, hit.point);*/
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
