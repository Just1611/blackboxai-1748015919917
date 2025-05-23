using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Handles input from steering wheel, pedals, and shifter.
/// Supports PXN V9 GEN 2 wheel via Unity Input System or DirectInput alternative.
/// </summary>
public class InputManager : MonoBehaviour
{
    public float steeringInput { get; private set; }
    public float throttleInput { get; private set; }
    public float brakeInput { get; private set; }
    public int gearInput { get; private set; }

    private void Update()
    {
        // TODO: Implement input reading from wheel, pedals, and shifter
        // Placeholder example using Unity Input System

        // Steering axis (-1 to 1)
        steeringInput = GetSteeringInput();

        // Throttle and brake (0 to 1)
        throttleInput = GetThrottleInput();
        brakeInput = GetBrakeInput();

        // Gear input (manual shifter)
        gearInput = GetGearInput();
    }

    private float GetSteeringInput()
    {
        // Example: read from Input System or fallback to keyboard
        if (Gamepad.current != null)
        {
            return Gamepad.current.leftStick.x.ReadValue();
        }
        else
        {
            return Input.GetAxis("Horizontal");
        }
    }

    private float GetThrottleInput()
    {
        // Example placeholder
        return Input.GetAxis("Throttle");
    }

    private float GetBrakeInput()
    {
        // Example placeholder
        return Input.GetAxis("Brake");
    }

    private int GetGearInput()
    {
        // Example placeholder for manual gear input
        if (Input.GetKeyDown(KeyCode.UpArrow))
            return 1;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            return -1;
        return 0;
    }
}
