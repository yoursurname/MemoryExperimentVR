using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// add the UXF namespace
using UXF;

// LINQ - for .OrderBy, etc
using System.Linq;

public class ExperimentGenerator : MonoBehaviour
{
    /// Store an array of transforms which defines the possible positons that they lie in.
    /// </summary>
    public Transform[] possiblePositions;

    public GameObject XR_Rig;

    // generate the blocks and trials for the session.
    // the session is passed as an argument by the event call.
    public void Generate(Session session)
    {

        // generate a practice block with 10 trials.
        /*
        int nPractice = session.settings.GetInt("practice_ntrials");
        Block practice = session.CreateBlock(nPractice);
        */

        // generate a single block with 10 trials.
        int nExp = session.settings.GetInt("experiment_ntrials");
        Block newBlock = session.CreateBlock(nExp);




        /* foreach (Trial trial in newBlock.trials)
         {
             //Randomize start room and delete - continious on SetupNextTrial script
             Transform transform1 = possiblePositions[Random.Range(0, possiblePositions.Length)];
             XR_Rig.transform.position = transform1.position;
             session.NextTrial.result["Stimuli"] = transform1;
             possiblePositions = possiblePositions.Where(val => val != transform1).ToArray();
         } */


        // shuffle the trial order, so the catch trials are in random positions
        //newBlock.trials.Shuffle();
    }

}