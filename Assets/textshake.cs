using UnityEngine;
using TMPro; // Include this for TextMeshPro support

public class TextShake : MonoBehaviour
{
    public TMP_Text textToShake; // Reference to the TMP_Text object
    public float shakeAmount = 10f; // How much the text will shake
    public float shakeSpeed = 0.1f; // How fast the shake will happen
    private Vector3 originalPosition; // To store the original position of the text

    private void Start()
    {
        // Store the original position of the text
        originalPosition = textToShake.transform.position;
    }

    private void Update()
    {
        // Call the ShakeText function every frame
        ShakeText();
    }

    private void ShakeText()
    {
        // Apply a random offset to the text position based on shakeAmount
        float shakeX = Random.Range(-shakeAmount, shakeAmount);
        float shakeY = Random.Range(-shakeAmount, shakeAmount);
        Vector3 shakePosition = new Vector3(shakeX, shakeY, originalPosition.z);

        // Move the text to the new shake position
        textToShake.transform.position = originalPosition + shakePosition;
    }
}