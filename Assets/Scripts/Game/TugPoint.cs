using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TugPoint : Interact
{
    public float tugforce = 10f;
    public AudioSource source;
    bool active = false;
    public float radius = 1f;
    public LineRenderer line;

    public void Awake()
    {
        source.mute = true;
        line.SetPosition(0, gameObject.transform.position);
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
            line.gameObject.SetActive(false);
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
                line.gameObject.SetActive(true);
                line.SetPosition(1, player.gameObject.transform.position);
                player.AddForce((transform.position - player.gameObject.transform.position).normalized, tugforce);
            }
            else
            {
                line.gameObject.SetActive(false);
                source.mute = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            source.mute = true;
            line.gameObject.SetActive(false);
        }
    }
}
