using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    private Rigidbody2D rb;
    public float minForce = 10f; // Minimum force to be applied
    public float maxForce = 100f; // Maximum force to be applied
    public float forceIncreaseRate = 10f; // Rate at which force increases per second while holding the spacebar

    private bool isLaunching = false; // Flag to track if spacebar is being held down
    private float currentForce = 0f; // Current force being applied

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isLaunching = true;
            currentForce = minForce;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isLaunching = false;
            Launch();
        }
    }

    void FixedUpdate()
    {
        if (isLaunching)
        {
            IncreaseForce();
        }
    }

    void IncreaseForce()
    {
        if (currentForce < maxForce)
        {
            currentForce += forceIncreaseRate * Time.deltaTime;
        }
    }

    void Launch()
    {
        rb.AddForce(transform.up * currentForce, ForceMode2D.Impulse);
    }
}
