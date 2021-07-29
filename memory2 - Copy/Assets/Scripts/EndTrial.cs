using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF; // <-- new

public class EndTrial : MonoBehaviour
{
    // reference to the UXF Session - so we can end the trial.
    public Session session; // <-- new

    // end current trial

    public void EndThisTrial()
    {

        session.EndCurrentTrial(); // <-- new
    }
    
}
