using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : Interact
{
    public GameObject prevScreen, newScreen, Target;
    public GameObject spawnpoint;
    CamControl cc;
    
    public override void Start()
    {
        base.Start();
        cc = cam.gameObject.GetComponent<CamControl>();
    }


    public void Changed()
    {
        cc.ScreenChange(Target, newScreen, prevScreen );
        player.setspawn(spawnpoint.transform.position);
    }
}
