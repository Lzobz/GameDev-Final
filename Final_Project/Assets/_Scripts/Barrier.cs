using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [Header("Inscribed")]
    public bool doesRotate;
    public GameObject spawnPoint;
    public GameObject bee;


    float rotSpeed = 100f;

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (doesRotate) {
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Entered");
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = spawnPoint.transform.position;

            Followmouse script = other.gameObject.GetComponent<Followmouse>();
            script.clickedBee = false;
            
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;

        }
    }
}
