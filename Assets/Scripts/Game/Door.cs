using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Walls
{
    public GameObject parentwall;
    /*
    public void Open()
    {
        gameObject.SetActive(false);
    }

    public void Close()
    {
        gameObject.SetActive(true);
    }
    */

    public void OpenDoor()
    {
        parentwall.SetActive(false);
    }
    public void CloseDoor()
    {
        parentwall.SetActive(true);
    }
}
