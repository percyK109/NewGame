using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // For TextMeshPro support
using UnityEngine.UI; // For regular Button support

public class SceneinputManager : MonoBehaviour
{
    public TMP_InputField inputField; // Reference to the TMP_InputField
    public Button submitButton; // Reference to the submit button (Unity's standard Button)
    public string correctInput = "Lollipop"; // Correct input to trigger scene loading
    public int sceneToLoad = 6; // Scene to load when the input is correct
    public TMP_Text feedbackText; // Reference to the TMP_Text component for feedback
    public int sceneToLoad2 = 1; // Alternative scene to load if input is incorrect

    void Start()
    {
        // Add listener to the submit button
        submitButton.onClick.AddListener(OnSubmit);

        // Initially hide feedback text (optional)
        feedbackText.gameObject.SetActive(false); // Hide feedback text on start
    }

    void OnSubmit()
    {
        // Check if the input matches the correct input
        if (inputField.text == correctInput)
        {
            // Provide feedback before loading
            feedbackText.gameObject.SetActive(false); // Hide feedback text when correct

            // Load the correct scene
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            // Show feedback and provide message if the input is incorrect
            feedbackText.gameObject.SetActive(true); // Show feedback text

            // Set the feedback text to indicate wrong input
            feedbackText.text = "WRONG!!!";

            // Load the alternative scene (optional)
            SceneManager.LoadScene(sceneToLoad2);
        }
    }
}