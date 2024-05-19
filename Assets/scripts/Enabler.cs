using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    private RigidbodyConstraints originalConstraints;
    // Start is called before the first frame update
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        originalConstraints = m_Rigidbody.constraints;
    }

    public void TurnOn()
    {
        m_Rigidbody.constraints = originalConstraints;
    }

    public void Turnoff()
    {
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;

    }

    // Update is called once per frame
    // void Update()
    // {
    //     // Get the current local position of the game object
    //     Vector3 currentLocalPos = transform.localPosition;
    //     // Set the y-coordinate of the local position to 0
    //     currentLocalPos.y = 0;
    //     // Apply the new local position to the game object
    //     transform.localPosition = currentLocalPos;
    // }
}
