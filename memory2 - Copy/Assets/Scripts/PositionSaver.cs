using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSaver : MonoBehaviour
{
    public Transform OriginalPos;

    /*void Start()
    {
        Vector3 OriginalPos = gameObject.transform.position;
    }*/

    public void Restore()
    {
        GetComponent<Transform>().position = OriginalPos.position;
    }
}
