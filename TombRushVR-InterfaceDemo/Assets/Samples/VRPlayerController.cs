using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// The VRPlayerController script is attached to the VR player game object.
// The spawnPoint variable is a reference to the spawn point game object that the player will teleport to when they hit the trigger object.
// The fadeCanvas variable is a reference to a canvas game object that contains an image component. This canvas is used to create a fade-in and fade-out effect when the player teleports.
// The fadeDuration variable determines how long the fade-in and fade-out effect will last.
// The isFading variable is used to prevent the player from triggering the teleportation sequence multiple times while the fade effect is still happening.
// The OnTriggerEnter method is called when the player collides with the trigger object. If the trigger object has the tag 
// "SpawnPoint" and the player is not already fading, the FadeOutAndIn coroutine is started.
// The FadeOutAndIn coroutine sets the isFading variable to true, activates the fade canvas, and fades out the screen. 
// Once the screen is fully faded out, the player is teleported to the new spawn point, and the screen is faded back in.


public class VRPlayerController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject fadeCanvas;
    public Transform DeathMessageSpawn;
    public GameObject DeathMessage;
    public float fadeDuration = 1.0f;

    private bool isFading = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isFading)
        {
            StartCoroutine(FadeOutAndIn(other.transform.position));
        }
    }

    private IEnumerator FadeOutAndIn(Vector3 spawnPosition)
    {
        isFading = true;

        // Fade out
        fadeCanvas.SetActive(true);
        float fadeStartTime = Time.time;
        while (Time.time < fadeStartTime + fadeDuration)
        {
            float alpha = (Time.time - fadeStartTime) / fadeDuration;
            fadeCanvas.GetComponent<CanvasGroup>().alpha = alpha;
            yield return null;
        }
        fadeCanvas.GetComponent<CanvasGroup>().alpha = 1.0f;

        // Teleport player and fade in
        transform.position = spawnPosition;
        Instantiate(DeathMessage, DeathMessageSpawn.position, DeathMessageSpawn.rotation);
        fadeStartTime = Time.time;
        while (Time.time < fadeStartTime + fadeDuration)
        {
            float alpha = 1 - ((Time.time - fadeStartTime) / fadeDuration);
            fadeCanvas.GetComponent<CanvasGroup>().alpha = alpha;
            yield return null;
        }
        fadeCanvas.GetComponent<CanvasGroup>().alpha = 0.0f;
        fadeCanvas.SetActive(false);

        isFading = false;
    }
}
