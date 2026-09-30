using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform targetPosition;
    public float speed = 5f;

    void Update()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition.position,
            Time.deltaTime * speed
        );

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetPosition.rotation,
            Time.deltaTime * speed
        );
    }
}