using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour
{
    bool paused = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (paused)
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        
    }
    public void UnPause()
    {

    }
    public void Win()
    {

    }
}
