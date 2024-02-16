using UnityEngine;

public class MoveAndDestroy : MonoBehaviour
{
    public Transform target; // The target object to move towards

    public float speed = 5f; // Speed at which the object moves

    void Update()
    {
        if (target == null)
        {
            Debug.LogError("Target is not assigned!");
            return;
        }

        // Calculate the direction to move towards the target
        Vector3 direction = (target.position - transform.position).normalized;

        // Move the object towards the target
        transform.Translate(direction * speed * Time.deltaTime);

        // Check for collision with the target
        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            // Destroy this object when it collides with the target
            Destroy(gameObject);
        }
    }
}