using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSaver : MonoBehaviour
{
    Material originalMat;

    void Start()
    {
        originalMat = GetComponent<Renderer>().material;
    }
    public void Restore()
    {
        GetComponent<Renderer>().material = originalMat;
    } 
}
