using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public void StopAudio()
    {
        AudioSource[] audioSources = GameObject.FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in audioSources)
            {
                audioSource.Pause();
            }    
    }

    public void ContinueAudio()
    {
        AudioSource[] audioSources = GameObject.FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in audioSources)
            {
                audioSource.UnPause();
            }    
    }
        
}
