using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target; // The object the camera will follow
    public float smoothSpeed = 0.125f; // The speed at which the camera will follow the target
    public Vector3 offset; // The offset of the camera from the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position for the camera
            Vector3 targetPosition = target.position + offset;

            // Ensure that z position remains the same as the camera
            targetPosition.z = transform.position.z;

            // Check if the target is moving
            if (target.GetComponent<Rigidbody2D>() != null)
            {
                Vector2 targetVelocity = target.GetComponent<Rigidbody2D>().velocity;
                if (targetVelocity.magnitude > 0.01f)
                {
                    // Smoothly move the camera towards the desired position
                    Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
                    transform.position = smoothedPosition;
                }
            }
            else
            {
                // Smoothly move the camera towards the desired position
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
                transform.position = smoothedPosition;
            }
        }
    }
}