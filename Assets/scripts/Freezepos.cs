using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezepos : MonoBehaviour
{
    public float freezeY = 0.1150436f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the game object
        Vector3 currentPos = transform.position;
        // Constraint: ensure the new position is never below the freezeY value
        currentPos.y = Mathf.Min(currentPos.y, freezeY);
        // Apply the new position to the game object
        transform.position = currentPos;
    }
}
