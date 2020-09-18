using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;

    private Rigidbody rb;

    public float shiftSpeed = 17f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = shiftSpeed;
        }
        else{
            speed = 20f;
        }

        if (Input.GetKey(KeyCode.F)) {
            speed = 10f;
        }
    }
}
