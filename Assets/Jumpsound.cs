using UnityEngine;

public class PlaySoundOnSpace : MonoBehaviour
{
    public AudioClip soundClip; // The sound clip to play
    private AudioSource audioSource; // The AudioSource component

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource is missing
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found on this GameObject.");
        }
    }

    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        // Play the sound only if the AudioSource and soundClip are assigned
        if (audioSource != null && soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
    }
}
