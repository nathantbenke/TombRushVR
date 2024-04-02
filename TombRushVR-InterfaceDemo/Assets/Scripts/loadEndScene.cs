using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadEndScene : MonoBehaviour
{
    public AudioSource roomTransition;


    private void OnTriggerEnter(Collider other)
    {
        roomTransition.Play();
        SceneManager.LoadScene(2);
    }
}
