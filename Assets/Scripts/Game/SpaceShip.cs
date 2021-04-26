using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public bool started = false;
    
    public SpriteRenderer old;
    public GameObject stick;
    public GameObject stars;
    public logic gamelogic;
    public float waittime1 = 3f;
    public float waittime2 = 2f;
    public float waittime3 = 5f;
    public Vector3 moverate;
    public void Begin()
    {
        started = true;
    }

    
    void FixedUpdate()
    {
        if (started)
        {
            waittime1 -= Time.fixedDeltaTime;
            if (waittime1 <= 0)
            {
                waittime2 -= Time.fixedDeltaTime;
                stars.SetActive(true);
                if (waittime2 <= 0)
                {
                    old.enabled = false;
                    stick.SetActive(true);
                    transform.position = transform.position + moverate;
                    waittime3 -= Time.fixedDeltaTime;
                    if (waittime3 <= 0)
                    {
                        gamelogic.Win();
                    }
                }
            }
        }
    }
}
