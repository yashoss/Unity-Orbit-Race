using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowChild : MonoBehaviour
{
    public Transform circleTransform;

    void Update()
    {
        transform.position = circleTransform.position;
    }
}
