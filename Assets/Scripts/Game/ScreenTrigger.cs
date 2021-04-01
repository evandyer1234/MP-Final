using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScreenTrigger : Walls
{
    public UnityEvent OnTrigger;
    public override void OnHit()
    {
        OnTrigger.Invoke();
    }
}
