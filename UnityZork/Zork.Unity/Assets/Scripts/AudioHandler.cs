using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioClip inputClip;

    //---------------------//
    public void PlayInput()
    //---------------------//
    {
        sfxSource.PlayOneShot(inputClip);

    }//END PlayInput


}//END AudioHandler
