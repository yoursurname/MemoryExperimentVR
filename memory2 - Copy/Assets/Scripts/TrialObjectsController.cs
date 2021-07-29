using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UXF;

public class TrialObjectsController : MonoBehaviour
{
    public Session session;
    public GameObject rooms;
    public GameObject Trial_objects;
    public GameObject Lure_obj;
    public GameObject trialobjectsroomtutorial;
    public GameObject Trial_objectsPractice;


    public void WhenObjectGrabbed()
    {

        //Write time of choice to results
        session.CurrentTrial.result["ObjectPickedTime"] = Time.time;

        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            ObjectFound.GetComponent<MaterialSaver>().Restore();
        }

        GameObject current = Selection.activeGameObject;

        if (Trial_objects != current)
        {
            Trial_objects.SetActive(false);
        }
    }

    public void WhenTutorialObjectGrabbed()
    {

        GameObject current = Selection.activeGameObject;

        if (trialobjectsroomtutorial != current)
        {
            trialobjectsroomtutorial.SetActive(false);
        }
    }

    public void WhenPracticeObjectGrabbed()
    {

        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            ObjectFound.GetComponent<MaterialSaver>().Restore();
        }

        GameObject current = Selection.activeGameObject;

        if (Trial_objectsPractice != current)
        {
            Trial_objectsPractice.SetActive(false);
        }
        
        /*foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Practicetrialobject"))
        {
            //Do something to ObjectFound, like this:
            if (ObjectFound != current)
            {
                ObjectFound.SetActive(false);
            }

        }*/
    }

}
