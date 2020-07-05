using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 movementSpeedVertical;

    [SerializeField]
    Vector3 movementSpeedHorizontal;

    [SerializeField]
    KeyCode up;

    [SerializeField]
    KeyCode down;

    [SerializeField]
    KeyCode left;

    [SerializeField]
    KeyCode right;


    void FixedUpdate()
    {
        if(Input.GetKey(up))
        {
            GetComponent<Rigidbody>().velocity += movementSpeedVertical;
        }

        if (Input.GetKey(down))
        {
            GetComponent<Rigidbody>().velocity -= movementSpeedVertical;
        }

        if (Input.GetKey(left))
        {
            GetComponent<Rigidbody>().velocity -= movementSpeedHorizontal;
        }

        if (Input.GetKey(right))
        {
            GetComponent<Rigidbody>().velocity += movementSpeedHorizontal;
        }
    }
}
