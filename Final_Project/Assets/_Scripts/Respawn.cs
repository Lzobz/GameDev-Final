using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject bee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBee()
    {
        Debug.Log("Hey");
        bee.transform.position = spawnPoint.transform.position;

        Followmouse script = bee.GetComponent<Followmouse>();
        script.clickedBee = false;

        Rigidbody rb = bee.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;

        bee.transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}
