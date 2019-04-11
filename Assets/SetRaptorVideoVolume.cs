using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetRaptorVideoVolume : MonoBehaviour
{
    public AudioMixer mixer;


    public void setLevel (float sliderValue)
    {   // sets audio level
        mixer.SetFloat("RaptorAudioVol", Mathf.Log10(sliderValue) * 20);
    }
}
