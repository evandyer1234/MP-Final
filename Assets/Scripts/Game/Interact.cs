using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Player player;
    public Vector3 Point;
    public Camera cam;

    public virtual void Start()
    {
        cam = Camera.main;
    }

    public virtual void Update()
    {
        Point = cam.ScreenToWorldPoint(Input.mousePosition);
        Point.z = 0;
    }

    public float GetDistanceTo(Vector3 main, Vector3 Other)
    {
        float distanceTo = (Other - main).magnitude;

        return distanceTo;
    }

    public void Open()
    {
        gameObject.SetActive(false);
    }

    public void Close()
    {
        gameObject.SetActive(true);
    }
}
