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

    private void Awake()
    {
        foreach (Interact i in FindObjectsOfType<Interact>())
        {
            i.player = this;
        }
    }

    void Update()
    {
        position = transform.position;
    }

    public void Die()
    {
        transform.position = Respawnpos;
        VelocityDir = new Vector3(0, 0, 0);
    }

    public void setspawn(Vector3 pos)
    {
        Respawnpos = pos;
    }
}
