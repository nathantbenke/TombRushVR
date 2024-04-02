using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAudioScript : MonoBehaviour
{
    public AudioSource selectNoise;

    public void selectNoiseFunc()
    {
        selectNoise.Play();

    }
}
