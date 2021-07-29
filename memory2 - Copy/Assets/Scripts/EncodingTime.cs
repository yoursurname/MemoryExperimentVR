using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

// add the UXF namespace     
using UXF; // <-- new
// LINQ - for .OrderBy, etc
using System.Linq;

public class EncodingTime : MonoBehaviour
{
    // reference to the UXF Session - so we can start the trial.
    public Session session; // <-- new
    public Material Invisible;
    public GameObject Distraction;
    public GameObject roomobjects;
    public GameObject Trial_objects;
    public EventSystem eventSystem;
    public Transform[] possiblePositions;
    public GameObject XR_Rig;


    public void RunEncodingTaskTrial(Trial trial)
    {
        Transform transform1 = possiblePositions[Random.Range(0, possiblePositions.Length)];
        XR_Rig.transform.position = transform1.position;
        session.CurrentTrial.result["Stimuli"] = transform1;
        possiblePositions = possiblePositions.Where(val => val != transform1).ToArray();

        Trial_objects.SetActive(false);
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(Countdown(trial));
    }
    //Specify time until end
    //What happens when encoding ends
    IEnumerator Countdown(Trial trial)
    {
        yield return new WaitForSeconds(3f);
        Distraction.SetActive(false);
        yield return new WaitForSeconds(5.5f);
        Distraction.SetActive(true);
        yield return new WaitForSeconds(3f);
        roomobjects.SetActive(false);
        Trial_objects.SetActive(true);
        Distraction.SetActive(false);
        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            //Do something to ObjectFound, like this:
            ObjectFound.GetComponent<Renderer>().material = Invisible;
        }
        //Write start time of retrieval phase to results
        session.CurrentTrial.result["RetrievalStartTime"] = Time.time;

        /*foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("StartPosition"))
        {
            if (XR_Rig.transform.position == ObjectFound.transform.position)
            {
                session.CurrentTrial.result["Room"] = ObjectFound;
            }
       
        } */

        //session.BeginNextTrial(); // <-- new
        //else roomobjects.SetActive(true);
    }

}