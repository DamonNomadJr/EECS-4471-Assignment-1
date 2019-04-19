using UnityEngine;
using System.Collections;

public class Ride : MonoBehaviour
{

    public float speed = 20;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {    
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(10f, 0.0f, 0f);

        rb.AddForce(movement * speed);
    }
}