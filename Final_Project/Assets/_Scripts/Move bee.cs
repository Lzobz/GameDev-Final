using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebee : MonoBehaviour
{
    private Camera cam;

  

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            if (raycastHit.collider.name == "Plane")
            {
                transform.position = raycastHit.point;
                print(transform.position);
            }
        }
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
            Debug.DrawLine(ray.origin, hit.point);
    }
}
