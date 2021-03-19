using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public float playEverySeconds = 5;
    private float timePassed = 0;
    public AudioSource myAudioSource;
 
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }
 
    void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= playEverySeconds)
        {
            timePassed = 0;
            myAudioSource.Play();
        }
    }
}
