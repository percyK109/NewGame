using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransporter : MonoBehaviour
{
    // The name of the scene to load
    public string sceneName;

    // This function is called when another collider enters the trigger collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player is the one entering the trigger
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}