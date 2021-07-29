using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableObject : MonoBehaviour
{

    public GameObject roomobjects;

    //Disable or enable another gameobject 
    public void WhenObjectGrabbed()
    {
        if (roomobjects.activeInHierarchy == true)
            roomobjects.SetActive(false);
        //else roomobjects.SetActive(true);
    }
}

