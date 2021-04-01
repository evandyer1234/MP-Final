using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject prevScreen, newScreen, Target;
    Camera cam;
    CamControl cc;
    
    void Start()
    {
        cam = Camera.main;
        cc = cam.gameObject.GetComponent<CamControl>();
    }


    public void Changed()
    {
        cc.ScreenChange(Target, newScreen, prevScreen );
    }
}
