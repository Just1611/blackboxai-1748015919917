using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the HUD elements: speed, RPM, gear indicator, and minimap.
/// </summary>
public class UIManager : MonoBehaviour
{
    public Text speedText;
    public Text rpmText;
    public Text gearText;
    public RawImage minimapImage;

    private Rigidbody playerCarRigidbody;

    private void Start()
    {
        // Assuming this script is attached to the HUD Canvas
        // Find the player car Rigidbody for speed and RPM data
        GameObject playerCar = GameObject.FindWithTag("Player");
        if (playerCar != null)
        {
            playerCarRigidbody = playerCar.GetComponent<Rigidbody>();
        }
    }

    private void Update()
    {
        if (playerCarRigidbody != null)
        {
            UpdateSpeed();
            UpdateRPM();
            UpdateGear();
        }
    }

    private void UpdateSpeed()
    {
        float speed = playerCarRigidbody.velocity.magnitude * 3.6f; // m/s to km/h
        speedText.text = $"Speed: {speed:F0} km/h";
    }

    private void UpdateRPM()
    {
        // Placeholder RPM calculation
        float rpm = Mathf.PingPong(Time.time * 1000f, 7000f);
        rpmText.text = $"RPM: {rpm:F0}";
    }

    private void UpdateGear()
    {
        // Placeholder gear display
        gearText.text = "Gear: 1";
    }
}
