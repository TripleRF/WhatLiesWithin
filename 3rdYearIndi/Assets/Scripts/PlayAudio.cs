using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    public AudioClip SoundGoesHere;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false; 

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundGoesHere, Volume);
            alreadyPlayed = true;
        }
    }
}
