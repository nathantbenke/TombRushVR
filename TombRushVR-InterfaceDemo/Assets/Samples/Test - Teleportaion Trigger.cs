using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportTrigger : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject fadeCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeOutAndTeleport(other.gameObject));
        }
    }

    private IEnumerator FadeOutAndTeleport(GameObject player)
    {
        // Activate fade canvas
        fadeCanvas.SetActive(true);

        // Fade out
        float fadeStartTime = Time.time;
        while (Time.time < fadeStartTime + 1.0f)
        {
            float alpha = (Time.time - fadeStartTime) / 1.0f;
            fadeCanvas.GetComponent<UnityEngine.UI.Image>().color = new Color(0.0f, 0.0f, 0.0f, alpha);
            yield return null;
        }
        fadeCanvas.GetComponent<UnityEngine.UI.Image>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        // Teleport player
        player.transform.position = spawnPoint.position;

        // Fade in
        fadeStartTime = Time.time;
        while (Time.time < fadeStartTime + 1.0f)
        {
            float alpha = 1.0f - ((Time.time - fadeStartTime) / 1.0f);
            fadeCanvas.GetComponent<UnityEngine.UI.Image>().color = new Color(0.0f, 0.0f, 0.0f, alpha);
            yield return null;
        }
        fadeCanvas.GetComponent<UnityEngine.UI.Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.0f);

        // Deactivate fade canvas
        fadeCanvas.SetActive(false);
    }
}
