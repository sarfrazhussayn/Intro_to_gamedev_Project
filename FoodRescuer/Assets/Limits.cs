using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float rightLimit;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        (
        	Mathf.Clamp(transform.position.x,leftLimit,rightLimit),
        	transform.position.y,
        	transform.position.z
        );
    }
}
