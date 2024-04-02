using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpikeTrapDeath : MonoBehaviour
{
    public Transform SpawnPoint;
    public Transform PlayerTransform;
    public Transform DeathMessageSpawn;
    public GameObject DeathMessage;

    public AudioSource deathNoise;

    // Start is called before the first frame update
    void Start()
    {
    }


    void OnTriggerEnter()
    {
        deathNoise.Play();
        PlayerTransform.position = SpawnPoint.position;
        Instantiate(DeathMessage, DeathMessageSpawn.position, DeathMessageSpawn.rotation);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
