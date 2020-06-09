using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed = 100;
    public Transform thrusterTransform;

    public float friction = 0.1f;

    private Rigidbody2D rb;
    private float thrusterAngle;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if  (Input.GetKeyUp(KeyCode.Space))
        {
            print("space key released");
            // Angle of the thruster relative to the Z axis in radians.
            thrusterAngle = thrusterTransform.rotation.eulerAngles.z * Mathf.Deg2Rad;
            rb.velocity = new Vector2(-Mathf.Sin(thrusterAngle) * speed, Mathf.Cos(thrusterAngle) * speed);
            print(rb.velocity);
        }
    }
}
