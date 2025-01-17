using UnityEngine;
using UnityEngine.Audio;

public class PlayMainMusic : MonoBehaviour
{
    public AudioMixer mainMixer; // Reference to the main AudioMixer
    public AudioClip mainMusic; // The music to play
    private AudioSource audioSource;

    void Start()
    {
        // Get or add an AudioSource component to the GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the AudioMixer output group to the AudioSource
        audioSource.outputAudioMixerGroup = mainMixer.FindMatchingGroups("Master")[0]; // Replace "Master" with the desired group name

        // Assign and play the music
        audioSource.clip = mainMusic;
        audioSource.loop = true; // Set to true if you want the music to loop
        audioSource.Play();
    }
}
