using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.5f;

    public Vector3 offset;

    private void Update()
    {
        transform.position = target.position + offset;
    }
}
