using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// LINQ - for .OrderBy, etc
using System.Linq;

public class TutorialController : MonoBehaviour
{

    public GameObject Instructions1;
    public GameObject Instructions2;
    public GameObject Instructions3;
    public GameObject Instructions4;
    public GameObject Instructions5;
    public GameObject Continue1;
    public GameObject Continue2;
    public GameObject Continue3;
    public GameObject Continue4;
    public GameObject StartExperiment;
    public GameObject RepeatTutorial;
    public GameObject RepeatTrial;
    public GameObject Objectsroomtutorial;
    public GameObject trialobjectsroomtutorial;

    public GameObject[] Trialobjz;

    /*
    public GameObject Correct_obj_p1;
    public GameObject Lure_obj_p1;
    public GameObject Lure_obj_p2;
    public GameObject Lure_obj_p1;
    public GameObject Lure_obj_p3;
    public GameObject Correct_obj_p1;
    public GameObject Correct_obj_p4;
    public GameObject Correct_obj_p1;
    public GameObject Correct_obj_p5;
    */

    public Material Invisible;
    public GameObject DistractionPractice;
    public GameObject roomobjectsPractice;
    public GameObject Trial_objectsPractice;
    public Transform[] possiblePositionsPractice;
    public Transform StartPosition1Practice;
    public Transform StartPosition2Practice;
    public Transform StartPosition3Practice;
    public Transform StartPosition4Practice;
    public Transform StartPosition5Practice;

    public Transform SpawnerLP1;
    public Transform SpawnerLP2;
    public Transform SpawnerLP3;
    public Transform SpawnerLP4;
    public Transform SpawnerLP5;
    public Transform SpawnerCP1;
    public Transform SpawnerCP2;
    public Transform SpawnerCP3;
    public Transform SpawnerCP4;
    public Transform SpawnerCP5;

    public Transform[] TrialobjectPositionsPractice;


    public Transform RestingPosition;
    public Transform ButtonPosition;
    public Transform ButtonPositionLeft;
    public Transform ButtonPositionRight;

    public Transform XR_Rigpos;

    public GameObject XR_Rig;

    public AudioClip failSound;

    public Transform StartPositionTutorial;


    public void Clickcontinue1() 
    {
        Instructions1.SetActive(false);
        Continue1.transform.position = new Vector3 (0f, 100f, 0f);
        Instructions2.SetActive(true);
        Continue2.transform.position = ButtonPosition.position;
        Objectsroomtutorial.SetActive(true);
        XR_Rig.transform.position = StartPositionTutorial.position;

        /*TrialobjectPositionsPractice[0].position = Trialobjz[0].transform.position;
        TrialobjectPositionsPractice[1].position = Trialobjz[1].transform.position;
        TrialobjectPositionsPractice[2].position = Trialobjz[2].transform.position;
        TrialobjectPositionsPractice[3].position = Trialobjz[3].transform.position;
        TrialobjectPositionsPractice[4].position = Trialobjz[4].transform.position;
        TrialobjectPositionsPractice[5].position = Trialobjz[5].transform.position;
        TrialobjectPositionsPractice[6].position = Trialobjz[6].transform.position;
        TrialobjectPositionsPractice[7].position = Trialobjz[7].transform.position;
        TrialobjectPositionsPractice[8].position = Trialobjz[8].transform.position;
        TrialobjectPositionsPractice[9].position = Trialobjz[9].transform.position;
        */


    }


    public void Clickcontinue2()
    {
        Instructions2.SetActive(false);
        Continue2.transform.position = new Vector3(0f, 200f, 0f);
        Objectsroomtutorial.SetActive(false);
        trialobjectsroomtutorial.SetActive(true);
        Instructions3.SetActive(true);
        Continue3.transform.position = ButtonPosition.position;

    }

    public void Clickcontinue3()
    {
        Instructions3.SetActive(false);
        Continue3.transform.position = new Vector3(0f, 300f, 0f);
        Instructions4.SetActive(true);
        Continue4.transform.position = ButtonPosition.position;


    }

    public void Clickcontinue4()
    {
        Trialobjz[0].transform.position = SpawnerCP1.position;
        Trialobjz[1].transform.position = SpawnerLP1.position;
        Trialobjz[2].transform.position = SpawnerCP2.position;
        Trialobjz[3].transform.position = SpawnerLP2.position;
        Trialobjz[4].transform.position = SpawnerCP3.position;
        Trialobjz[5].transform.position = SpawnerLP3.position;
        Trialobjz[6].transform.position = SpawnerCP4.position;
        Trialobjz[7].transform.position = SpawnerLP4.position;
        Trialobjz[8].transform.position = SpawnerCP5.position;
        Trialobjz[9].transform.position = SpawnerLP5.position;
        //Trial_objectsPractice.SetActive(false);

        Instructions4.SetActive(false);
        Continue4.transform.position = new Vector3(0f, 400f, 0f);
        Instructions5.SetActive(true);
        StartExperiment.transform.position = ButtonPosition.position;
        RepeatTutorial.transform.position = ButtonPositionLeft.position;
        RepeatTrial.transform.position = ButtonPositionRight.position;

    }

    public void Clickrepeattutorial()
    {
        Instructions5.SetActive(false);
        StartExperiment.transform.position = new Vector3(0f, 500f, 0f);
        RepeatTutorial.transform.position = new Vector3(0f, 600f, 0f);
        RepeatTrial.transform.position = new Vector3(0f, 700f, 0f);
        Instructions1.SetActive(true);
        Continue1.transform.position = ButtonPosition.position;

    }

    public void Clickrepeattrial()
    {
        Instructions5.SetActive(false);
        StartExperiment.transform.position = new Vector3(0f, 500f, 0f);
        RepeatTutorial.transform.position = new Vector3(0f, 600f, 0f);
        RepeatTrial.transform.position = new Vector3(0f, 700f, 0f);
        Instructions4.SetActive(true);
        Continue4.transform.position = ButtonPosition.position;

    }



    public void RunPracticeTrials()
    {
        /* Transform transform1 = possiblePositionsPractice[Random.Range(0, possiblePositionsPractice.Length)];
         if (possiblePositionsPractice.Length == 1)
         {
             XR_Rig.transform.position = StartPositionTutorial.position;
             possiblePositionsPractice[0] = StartPosition1Practice;
             possiblePositionsPractice[1] = StartPosition2Practice;
             possiblePositionsPractice[2] = StartPosition3Practice;
             possiblePositionsPractice[3] = StartPosition4Practice;
             possiblePositionsPractice[4] = StartPosition5Practice;
         }
         else
         {
             XR_Rig.transform.position = transform1.position;
             possiblePositionsPractice = possiblePositionsPractice.Where(val => val != transform1).ToArray();
        */

        Trial_objectsPractice.SetActive(false);

        if (XR_Rigpos.position == StartPositionTutorial.position)
        {
            XR_Rig.transform.position = StartPosition1Practice.position;
            //Trial_objectsPractice.SetActive(false);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(Countdown());
        }
        else if (XR_Rigpos.position == StartPosition1Practice.position)
        {
            XR_Rig.transform.position = StartPosition2Practice.position;
            //Trial_objectsPractice.SetActive(false);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(Countdown());
        }
        else if (XR_Rigpos.position == StartPosition2Practice.position)
        {
            XR_Rig.transform.position = StartPosition3Practice.position;
            //Trial_objectsPractice.SetActive(false);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(Countdown());
        }
        else if (XR_Rigpos.position == StartPosition3Practice.position)
        {
            XR_Rig.transform.position = StartPosition4Practice.position;
            //Trial_objectsPractice.SetActive(false);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(Countdown());
        }
        else if (XR_Rigpos.position == StartPosition4Practice.position)
        {
            XR_Rig.transform.position = StartPosition5Practice.position;
            //Trial_objectsPractice.SetActive(false);
            //Start the coroutine we define below named ExampleCoroutine.
            StartCoroutine(Countdown());
        }
        else 
        {
            XR_Rig.transform.position = StartPositionTutorial.position;
        }

        //Specify time until end
        //What happens when encoding ends
        IEnumerator Countdown()
        {
            yield return new WaitForSeconds(3f);
            DistractionPractice.SetActive(false);
            yield return new WaitForSeconds(5.5f);
            DistractionPractice.SetActive(true);
            yield return new WaitForSeconds(3f);
            roomobjectsPractice.SetActive(false);
            Trial_objectsPractice.SetActive(true);
            DistractionPractice.SetActive(false);
            foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
            {
                //Do something to ObjectFound, like this:
                ObjectFound.GetComponent<Renderer>().material = Invisible;
            }

            /*foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Practicetrialobject"))
            {
                //Do something to ObjectFound, like this:
                Practicetrialobjectstartposition = ObjectFound.transform.position;
            }*/
        }


    }

    /*public void ReturnToOriginalPosition()
    {
        Trialobjz[0].transform.position = SpawnerCP1.position;
        Trialobjz[1].transform.position = SpawnerLP1.position;
        Trialobjz[2].transform.position = SpawnerCP3.position;
        Trialobjz[3].transform.position = SpawnerLP2.position;
        Trialobjz[4].transform.position = SpawnerCP3.position;
        Trialobjz[5].transform.position = SpawnerLP3.position;
        Trialobjz[6].transform.position = SpawnerCP4.position;
        Trialobjz[7].transform.position = SpawnerLP4.position;
        Trialobjz[8].transform.position = SpawnerCP5.position;
        Trialobjz[9].transform.position = SpawnerLP5.position;

    } */

    public void DelayedSetupPractice()
    {

        //Display distractor
        DistractionPractice.SetActive(true);

        //Return trial objects to original position;
        /*foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("Practicetrialobject"))
        {
            //Do something to ObjectFound, like this:
            ObjectFound.GetComponent<PositionSaver>().Restore();
        } */

        Trialobjz[0].transform.position = SpawnerCP1.position;
        Trialobjz[1].transform.position = SpawnerLP1.position;
        Trialobjz[2].transform.position = SpawnerCP2.position;
        Trialobjz[3].transform.position = SpawnerLP2.position;
        Trialobjz[4].transform.position = SpawnerCP3.position;
        Trialobjz[5].transform.position = SpawnerLP3.position;
        Trialobjz[6].transform.position = SpawnerCP4.position;
        Trialobjz[7].transform.position = SpawnerLP4.position;
        Trialobjz[8].transform.position = SpawnerCP5.position;
        Trialobjz[9].transform.position = SpawnerLP5.position;

        //Reinstate objects for encoding
        roomobjectsPractice.SetActive(true);

        //Trial_objectsPractice.SetActive(false);

        foreach (GameObject ObjectFound in GameObject.FindGameObjectsWithTag("BaseRoom"))
        {
            ObjectFound.GetComponent<MaterialSaver>().Restore();
        }
    }

    public void BeginCountdownPractice()
    {
        StartCoroutine(CountdownSlow());
    }

    public void StopCountdownSlow()
    {
        StopAllCoroutines();
    }

    IEnumerator CountdownSlow()
    {
        //Time to place object before trial ends
        yield return new WaitForSeconds(30f);

        // we will play a clip at position above origin, 100% volume
        AudioSource.PlayClipAtPoint(failSound, new Vector3(0, 1.3f, 0), 1.0f);
    }
}
