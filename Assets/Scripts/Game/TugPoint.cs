using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TugPoint : Interact
{
    public float tugforce = 10f;
    public AudioSource source;
    bool active = false;
    public float radius = 1f;

    public void Awake()
    {
        source.mute = true;
    }

    public override void Update()
    {
        base.Update();
        if (GetDistanceTo(gameObject.transform.position, Point) < radius)
        {
            active = true;
        }
        else
        {
            active = false;
            source.mute = true;
        }
        if (active)
        {
            ApplyForce();
        }
    }

    public virtual void ApplyForce()
    {
        if (Input.GetMouseButton(0))
        {
            if (GetDistanceTo(transform.position, Point) <= radius)
            {
                source.mute = false;
                player.AddForce((transform.position - player.gameObject.transform.position).normalized, tugforce);
            }
            else
            {
                source.mute = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            source.mute = true;
        }
    }
}
