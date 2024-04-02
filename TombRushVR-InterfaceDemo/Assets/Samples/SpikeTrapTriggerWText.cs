using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
/*
public class SpikeTrapTriggerWText : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform PlayerTransform;
    public Text deathMessage;

    private float fadeTime;
    private bool fadeIn;

    void Start()
    {
        deathMessage.CrossFadeAlpha(0, 0.0f, false);
        fadeTime = 0;
        fadeIn = false;
    }


    void OnTriggerEnter()
    {
        PlayerTransform.position = SpawnPoint.position;
        fadingIn = true;
    //    deathMessage.text = other.name;
    //    Instantiate(DeathMessage, DeathMessageSpawn.position, DeathMessageSpawn.rotation);
    }

    void Update()
    {
        if (fadeIn)
        {
            fadeIn();
        } else if (deathMessage.color.a != 0)
        {
            deathMessage.CrossFadeAlpha(0, 0.5f, false);
        }

    }


    void FadeIn()
    {
        deathMessage.CrossFadeAlpha(1, 0.5f, false);
        fadeTime += Time.deltaTime;
        if (deathMessage.color.a == 1 && fadeTime > 1.5) 
        {
            fadingIn = false;
            fadeTime = 0;
        
        
        }


    }
}
*/