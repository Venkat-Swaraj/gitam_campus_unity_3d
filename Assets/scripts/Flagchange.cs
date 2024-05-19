using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flagchange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject x;
    public ParticleSystem Yourps;
    public AudioSource Anthem;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == x)
        {
            Debug.Log("Collided");
            Yourps.Play();
            Invoke("player", 10.0f);
        }
    }

    private void player()
    {
        Anthem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
