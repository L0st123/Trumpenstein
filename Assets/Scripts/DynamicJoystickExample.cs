using UnityEngine;

public class DynamicJoystickExample : MonoBehaviour
{
    public DynamicJoystick dynamicJoystick; // Reference to the dynamic joystick
    public Transform playerBody;            // Reference to the player body for horizontal rotation
    public float sensitivity = 2f;          // Adjust sensitivity for rotation speed

    private float xRotation = 0f;           // For vertical (pitch) rotation

    void Update()
    {
        // Get input from the dynamic joystick
        float horizontal = dynamicJoystick.Horizontal;
              // Apply sensitivity
        float mouseX = horizontal * sensitivity;
            // Rotate player horizontally (yaw)
        playerBody.Rotate(Vector2.up * mouseX);
    }
}
