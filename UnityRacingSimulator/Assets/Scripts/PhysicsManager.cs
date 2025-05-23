using UnityEngine;

/// <summary>
/// Manages realistic car physics including suspension, tire grip, aerodynamics, and tire wear.
/// </summary>
public class PhysicsManager : MonoBehaviour
{
    [Header("Suspension")]
    public float suspensionTravel = 0.3f;
    public float suspensionStiffness = 20000f;
    public float suspensionDamping = 4500f;

    [Header("Tires")]
    public float tireGrip = 1.0f;
    public float tireWearRate = 0.01f;
    private float tireWear = 0f;

    [Header("Aerodynamics")]
    public float downforceCoefficient = 3.0f;
    public float dragCoefficient = 0.3f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("PhysicsManager requires a Rigidbody component.");
        }
    }

    private void FixedUpdate()
    {
        ApplySuspension();
        ApplyAerodynamics();
        SimulateTireWear();
    }

    private void ApplySuspension()
    {
        // TODO: Implement independent suspension per wheel
        // Placeholder for suspension forces
    }

    private void ApplyAerodynamics()
    {
        if (rb == null) return;

        float speed = rb.velocity.magnitude;
        Vector3 downforce = -transform.up * downforceCoefficient * speed * speed;
        Vector3 drag = -rb.velocity.normalized * dragCoefficient * speed * speed;

        rb.AddForce(downforce);
        rb.AddForce(drag);
    }

    private void SimulateTireWear()
    {
        // Placeholder tire wear simulation
        tireWear += tireWearRate * Time.fixedDeltaTime;
        tireWear = Mathf.Clamp01(tireWear);
    }
}
