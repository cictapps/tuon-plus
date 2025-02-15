using System.Collections;
using UnityEngine;

public class endCanvas : MonoBehaviour
{
    public GameObject popup;  // Reference to the GameObject you want to appear
    public float fadeDuration = 1.0f;  // Duration for the fade-in effect

    private CanvasGroup canvasGroup;

    void Start()
    {
        // Ensure the popup GameObject is active
        popup.SetActive(true);

        // Try to get the CanvasGroup component; if not found, add it
        canvasGroup = popup.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = popup.AddComponent<CanvasGroup>();  // Add CanvasGroup if missing
        }

        // Initially hide the popup by setting its alpha to 0 (fully transparent)
        canvasGroup.alpha = 0f;

        // Start the coroutine to activate and fade in the object after 3 seconds
        StartCoroutine(ActivateAndFadeIn());
    }

    IEnumerator ActivateAndFadeIn()
    {
        // Wait for 3 seconds before starting the fade-in
        yield return new WaitForSeconds(3f);

        // Gradually increase the alpha value to make the popup appear
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / fadeDuration);  // Fade in
            yield return null;
        }

        // Ensure the alpha is fully set to 1 after fading
        canvasGroup.alpha = 1f;
    }
}
