using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysObject : MonoBehaviour
{
    public Vector3 VelocityDir;
    
    public float Mass = 2f;
    public float veldeg = 0.7f;

    
    void FixedUpdate()
    {
        VelocityDir *= veldeg;
        gameObject.transform.position += VelocityDir * Time.fixedDeltaTime * Mass;
    }

    public void AddForce(Vector3 dir, float force)
    {
        VelocityDir += dir * force;
    }
}
