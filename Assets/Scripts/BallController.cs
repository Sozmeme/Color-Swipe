using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f; // �������� �������� ����
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // ��������� ��������� ���� �� �����������
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalVelocity = new Vector3(horizontalInput, 0f, 0f) * speed;
        rb.velocity = new Vector3(horizontalVelocity.x, rb.velocity.y, horizontalVelocity.z);
    }
}
