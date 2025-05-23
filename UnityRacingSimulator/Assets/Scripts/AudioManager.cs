using UnityEngine;

/// <summary>
/// Manages 3D audio for engine, collisions, tires, and environment.
/// </summary>
public class AudioManager : MonoBehaviour
{
    public AudioSource engineAudioSource;
    public AudioSource collisionAudioSource;
    public AudioSource tireAudioSource;
    public AudioSource environmentAudioSource;

    private Rigidbody playerCarRigidbody;

    private void Start()
    {
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
            UpdateEngineSound();
        }
    }

    private void UpdateEngineSound()
    {
        // Placeholder: Adjust pitch and volume based on speed or RPM
        float speed = playerCarRigidbody.velocity.magnitude;
        engineAudioSource.pitch = Mathf.Lerp(0.5f, 2.0f, speed / 50f);
        engineAudioSource.volume = Mathf.Lerp(0.3f, 1.0f, speed / 50f);
    }

    public void PlayCollisionSound()
    {
        if (!collisionAudioSource.isPlaying)
        {
            collisionAudioSource.Play();
        }
    }

    public void PlayTireSound()
    {
        if (!tireAudioSource.isPlaying)
        {
            tireAudioSource.Play();
        }
    }
}
