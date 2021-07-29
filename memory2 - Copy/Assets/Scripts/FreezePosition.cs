using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UXF; // <-- new

public class FreezePosition : MonoBehaviour
{

    public Session session; // <-- new
    Rigidbody m_Rigidbody;


    public void Freezeposition()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
    }

}
