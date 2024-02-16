using UnityEngine;
using System.Collections;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject trap; // Reference to the trap GameObject
    [SerializeField]
    private float delayBeforeDisable = 1f; // Delay before disabling the collider in seconds

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ActivateTrapWithDelay());
        }
    }

    // Coroutine to activate the trap with a delay
    private IEnumerator ActivateTrapWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeDisable);

        // Disable collider
        trap.GetComponent<Collider2D>().enabled = false;

        // Disable SpriteRenderer
        trap.GetComponent<SpriteRenderer>().enabled = false;
    }
}
