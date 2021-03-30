using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.RotateAround(gameObject.transform.position, transform.forward, speed * Time.fixedDeltaTime);
    }
}
