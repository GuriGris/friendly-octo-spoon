using TMPro;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float maxSpeed = 5f;
    [SerializeField] private float rotationSpeed = 5f;
    public TMP_Text speedText;

    private void Awake() {
        player = transform;
    }

    private void Update() {
        Vector3 mousePosition = Input.mousePosition;

        // Convert mouse position to world coordinates
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the Z position to the same as the player to avoid depth issues
        mousePosition.z = transform.position.z;

        float distanceToMouse = Vector2.Distance(mousePosition, player.position);

        // Calculate the direction vector from the player to the mouse position
        Vector3 direction = mousePosition - transform.position;

        // Calculate the angle in degrees and apply it to the Z-axis
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Calculate the target rotation based on the angle
        Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        // Smoothly rotate towards the target rotation using slerp
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        float currentSpeed = distanceToMouse * 0.75f * speed;

        // Clamp the speed to the maximum speed
        currentSpeed = Mathf.Min(currentSpeed, maxSpeed);
        if (currentSpeed < 0.05f) {
            currentSpeed = 0f;
        }
        speedText.text = $"Speed: {currentSpeed}";

        transform.Translate(Vector3.up * currentSpeed * Time.deltaTime);
    }
}