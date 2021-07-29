using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF;
using UnityEngine.XR.Interaction.Toolkit;
// LINQ - for .OrderBy, etc
using System.Linq;
public class SetupNextTrial : MonoBehaviour
{
    public Session session;
    public GameObject Distraction;
    public GameObject XR_Rig;
    public GameObject roomobjects;
    public GameObject Trial_objects;
    public Transform[] possiblePositions;
    //public Transform newstartposition;


    public void DelayedSetup()
    {
        StartCoroutine(SetupSequence());
    }

    IEnumerator SetupSequence()
    {

        //Delay time until next trial
        yield return new WaitForSeconds(2f);

        //Display distractor
        Distraction.SetActive(true);

        //Move camera to new room
        //Randomize next room and deletes from array to prevent repetition
        /*Transform transform1 = possiblePositions[Random.Range(0, possiblePositions.Length)];
        XR_Rig.transform.position = transform1.position;
        session.NextTrial.result["Stimuli"] = transform1;
        possiblePositions = possiblePositions.Where(val => val != transform1).ToArray();
        */

        //Reinstate objects for encoding
        roomobjects.SetActive(true);

        //Trial_objects.SetActive(true); 

        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            ObjectFound.GetComponent<MaterialSaver>().Restore();
        }
            //Here a new trial should begin and encoding script takeover
            session.BeginNextTrial();
    }
}