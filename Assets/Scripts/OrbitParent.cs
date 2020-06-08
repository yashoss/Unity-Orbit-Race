using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitParent : MonoBehaviour
{
    public float speed;
    public bool isRotating = true;
    public Transform parent;

    private Vector3 zAxis = new Vector3(0, 0, 1);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRotating = false;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isRotating = true;
        }
        if (isRotating)
        {
           transform.RotateAround(parent.position, zAxis, speed * Time.deltaTime);
        }

        // Recalculate the position and rotation of thruster every update step
        // in case circle/ball is still moving
        transform.position = circle.position + Vector3.down;
        transform.rotation = Quaternion.identity;
        transform.RotateAround(circle.position, zAxis, rotationAmount);
    }
}
