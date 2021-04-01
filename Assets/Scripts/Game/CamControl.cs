using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CamControl : MonoBehaviour
{
    public GameObject target;
    public float movespeed = 20f;
    public bool moving = false;
    public float mindis = 0.1f;
    Vector3 MoveDirection;
    public UnityEvent OnCamMoveEnd;
    public UnityEvent OnCamMoveStart;
    public List<GameObject> Sections = new List<GameObject>();
    GameObject oldsection;
    public void Start()
    {
        foreach (GameObject i in Sections)
        {
            i.SetActive(false);
        }
        Sections[0].SetActive(true);
    }
    void Update()
    {
        if (moving)
        {
            MoveDirection = (target.transform.position - transform.position).normalized;
            transform.position += (Time.unscaledDeltaTime * MoveDirection * movespeed);
            if (IsCloseToTarget())
            {
                ScreenChangeEnd();
            }
        }
    }

    public void ScreenChange(GameObject tar, GameObject newsec, GameObject oldsec)
    {
        OnCamMoveStart.Invoke();
        oldsection = oldsec;
        newsec.SetActive(true);
        Time.timeScale = 0f;
        moving = true;
        target = tar;
    }

    public void ScreenChangeEnd()
    {
        oldsection.SetActive(false);
        Time.timeScale = 1f;
        moving = false;
        OnCamMoveEnd.Invoke();
    }

    public float GetDistanceTo(Vector3 main, Vector3 Other)
    {
        float distanceTo = (Other - main).magnitude;

        return distanceTo;
    }

    public bool IsCloseToTarget()
    {

        if (GetDistanceTo(gameObject.transform.position, target.gameObject.transform.position) < mindis)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
