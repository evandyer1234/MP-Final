using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysObject
{
    public Vector3 position;
    public float radius = 1f;
    public Vector3 Respawnpos;

    void Start()
    {
        foreach (Interact i in FindObjectsOfType<Interact>())
        {
            i.player = this;
        }
        Respawnpos = transform.position;
    }
   
    void Update()
    {
        position = transform.position;
    }

    public void Die()
    {
        transform.position = Respawnpos;
    }
}
