using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UXF;

//Write Results to csv

public class WriteResults : MonoBehaviour
{
    public Session session;
    public GameObject Trial_objects;
    public Transform targetpos;
    public Transform Correctobjectpos;
    public Transform Lureobjectpos;

    public void WhenCorrect()
    {
        session.CurrentTrial.result["outcome"] = "Correct";
        session.CurrentTrial.result["DistanceToTarget"] = Vector3.Distance(Correctobjectpos.position, targetpos.position);
    }


    public void WhenLure()
        {
            session.CurrentTrial.result["outcome"] = "Wrong";
            session.CurrentTrial.result["DistanceToTarget"] = Vector3.Distance(Lureobjectpos.position, targetpos.position);
        }

}

