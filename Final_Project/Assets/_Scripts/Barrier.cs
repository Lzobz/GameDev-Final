using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [Header("Inscribed")]
    public bool doesRotate;

    float rotSpeed = 100f;

    


    // Start is called before the first frame update
    void Start()
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
            Destroy(other.gameObject);
        }
    }
}
