using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Followmouse : MonoBehaviour
{
    Rigidbody BeeRigidbody;
    public bool clickedBee = false;

    public float moveSpeed = 1f;

    private void Start()
    {
        BeeRigidbody = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //check for left mouse button click
            //create ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            { //perform ray cast

                if (hit.collider.gameObject.tag == "Player")
                {
                    clickedBee = true;
                }

            }

        }

        //move the bee if it has been clicked
        if (clickedBee)
        {
            //mouse pos to 3d world pos
            Vector3 mousePos2D = Input.mousePosition;
            mousePos2D.z = -Camera.main.transform.position.z;
            Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

            //Direction
            Vector3 direction = mousePos3D - transform.position;

            if (direction.magnitude > 0.3f) //This is to stop the vibration.
            {
                direction = direction.normalized;
                Vector3 targetVelocity = Vector3.Lerp(BeeRigidbody.velocity, direction * moveSpeed, moveSpeed); //using lerp smooths the bee's movement

                BeeRigidbody.velocity = targetVelocity;
                
                //Does rotation
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.Euler(0, 0, angle + 90);


            }
            else
            {
                BeeRigidbody.velocity = BeeRigidbody.velocity * 0.9f;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        BeeRigidbody.velocity = Vector3.zero;
    }
}
