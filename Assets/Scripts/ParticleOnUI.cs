using UnityEngine;
using UnityEngine.UI;

public class ParticleOnUI : MonoBehaviour
{
    public Transform targetUIElement; // Reference to the UI element to follow
    private RectTransform rectTransform;
    private Vector3 offset = new Vector3(0, 10, 0); // Offset to adjust the particle effect's position

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (targetUIElement != null)
        {
            // Calculate the screen position of the UI element
            Vector2 screenPos = Camera.main.WorldToScreenPoint(targetUIElement.position + offset);

            // Update the position of the UI Image to match the screen position
            rectTransform.position = screenPos;
        }
    }
}
