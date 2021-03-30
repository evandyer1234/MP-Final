using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : Interact
{
    public float radius = 2f;
    public logic l;
    public override void Update()
    {
        if (GetDistanceTo(player.position, transform.position) <= radius)
        {
            l.Win();
        }
    }
}
