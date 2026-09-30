using UnityEngine;

public class MenuCameraMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 0.5f;
    public Vector3 moveDirection = new Vector3(0, 0, 1);

    [Header("Rotation")]
    public float rotationSpeed = 2f;
    public Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        // Move camera
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Rotate camera
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
