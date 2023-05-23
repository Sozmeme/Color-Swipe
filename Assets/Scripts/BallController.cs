using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float hspeed = 5f; // скорость движения шара
    public float vspeed = 1.0f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // управляем движением шара по горизонтали
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput * hspeed, rb.velocity.y, vspeed);
        rb.AddForce(movement);
    }
}
