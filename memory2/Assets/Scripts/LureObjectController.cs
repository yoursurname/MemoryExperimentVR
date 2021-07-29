using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UXF;

public class LureObjectController : MonoBehaviour
{
    public Session session;
    public GameObject rooms;
    public GameObject Trial_objects;
    public GameObject Correct_obj;


    public void WhenObjectGrabbed()
    {
        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            ObjectFound.GetComponent<MaterialSaver>().Restore();
        }
        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("CorrectObject"))
        {
            ObjectFound.SetActive(false);
        }
        //session.CurrentTrial.result["outcome"] = "Wrong";
    }
}
