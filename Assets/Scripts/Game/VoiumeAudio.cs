using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VoiumeAudio : MonoBehaviour
{
    
    private AudioSource auidoSrc;
    private float musicVoiume;

    // Start is called before the first frame update
    void Start()
    {
       auidoSrc = GetComponent<AudioSource>();

        musicVoiume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        auidoSrc.volume = musicVoiume;
        
    }
    public void SetV(float vol){
        musicVoiume = vol;
    }
}

