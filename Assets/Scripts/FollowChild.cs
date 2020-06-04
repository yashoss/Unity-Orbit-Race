using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowChild : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        transform.position = transform.Find("Circle").position;
    }
}
