using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startpos;
    private float repeatWidth;

    void Start()
    {
        startpos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startpos.x - repeatWidth)
        {
            transform.position = startpos;
        }
    }

 
}


