using UnityEngine;
using UnityEngine.InputSystem;  // Add this for the new Input System

public class linegen : MonoBehaviour
{
    public GameObject linePrefab;
    Line activeLine;

    void Update()
    {
        // Use Input System's mouse button press check
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject newLine = Instantiate(linePrefab);
            activeLine = newLine.GetComponent<Line>();
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            activeLine.UpdateLine(mousePos);
        }
    }
}