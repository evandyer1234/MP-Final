using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Walls
{
    public override void OnHit()
    {
        player.Die();
    }
}
