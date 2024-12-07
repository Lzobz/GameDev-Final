using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Followmouse : MonoBehaviour
{
    Vector3 launchPos = new Vector3(0, 0, 0);
    public GameObject Bee;
    Rigidbody projectileRigidbody;
    // Start is called before the first frame update

    private void Start()
    {
        projectileRigidbody = Bee.GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 mouseDelta = mousePos3D - launchPos;
        Vector3 projPos = launchPos + mouseDelta;  
        Bee.transform.position = projPos;
    }
}
