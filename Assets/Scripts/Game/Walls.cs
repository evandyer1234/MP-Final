using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : Interact
{
    public bool custombounds = false;
    public bool longwall = false;
    public Walls top, bottom;
    public Vector3 TopLeft, BottomRight;
    public bool segment = false;

    [Tooltip("If true, collisions will be floors and ceilings, of not it will be left and right")]
    public bool TopWall = true;

    [Tooltip("Amount of velocity lost hitting a wall, leave at 1 if no velocity will be lost")]
    public float bouncedeg = 1f;
    public float downtime = 0.1f;
    float current;

    Renderer rend;
    public override void Start()
    {
        base.Start();
        

        if (longwall)
        {
            TopLeft = top.TopLeft;
            BottomRight = bottom.BottomRight;
        }
        current = downtime;
    }
    public void Awake()
    {
        rend = GetComponent<Renderer>();
        if (!custombounds)
        {
            TopLeft = new Vector3(rend.bounds.max.x - 1f, rend.bounds.max.y, rend.bounds.max.z);
            BottomRight = new Vector3(rend.bounds.max.x, rend.bounds.max.y - 1f, rend.bounds.max.z);
        }

    }
    public void FixedUpdate()
    {
        current -= Time.fixedDeltaTime;
        if (segment)
        {
            this.enabled = false;
        }
        if (!segment)
        {
            Debug.Log(TopLeft);
            Debug.Log(BottomRight);
        }
        if (TopWall)
        {
            if (player.position.y + player.radius >= BottomRight.y && player.position.y + player.radius <= TopLeft.y && player.position.x + player.radius >= TopLeft.x && player.position.x + player.radius <= BottomRight.x)
            {
                OnHit();
            }
            else if (player.position.y - player.radius <= TopLeft.y && player.position.y - player.radius >= BottomRight.y && player.position.x + player.radius >= TopLeft.x && player.position.x + player.radius <= BottomRight.x)
            {
                OnHit();
            }
        }
        else
        {
            if (player.position.x + player.radius >= TopLeft.x && player.position.x - player.radius <= BottomRight.x && player.position.y <= TopLeft.y && player.position.y >= BottomRight.y)
            {
                OnHit();
            }
            else if (player.position.x - player.radius <= BottomRight.x && player.position.x + player.radius > TopLeft.x && player.position.y <= TopLeft.y && player.position.y >= BottomRight.y)
            {
                OnHit();
            }
        }
    }

    public virtual void OnHit()
    {

        Debug.Log(gameObject.name);
        if (current <= 0)
        {
            if (TopWall)
            {
                player.VelocityDir = new Vector3(player.VelocityDir.x, -player.VelocityDir.y, player.VelocityDir.z);
            }
            else
            {
                player.VelocityDir = new Vector3(-player.VelocityDir.x, player.VelocityDir.y, player.VelocityDir.z);
            }
            current = downtime;
        }
    }
}
