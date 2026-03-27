using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarMovement : MonoBehaviour
{
    [Header("Acceleration Settings")]
    public float forwardAcceleration = 15f;
    public float steerAcceleration = 25f;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // 1. Get mass
        float mass = rb.mass; 

        // 2. Calculate Newton's Second Law: F = ma for forward movement
        float forwardForce = mass * forwardAcceleration; 
        rb.AddForce(transform.forward * forwardForce);

        // 3. Calculate F = ma for steering
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float steerForce = mass * steerAcceleration * horizontalInput; 
        rb.AddForce(transform.right * steerForce);
    }
}