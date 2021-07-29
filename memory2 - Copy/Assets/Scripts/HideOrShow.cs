using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOrShow : MonoBehaviour
{
    public Material Invisible;


    public void WhenObjectGrabbed()
    {
        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            //Do something to ObjectFound, like this:
            ObjectFound.GetComponent<Renderer>().material = Invisible;
        }
    }
}