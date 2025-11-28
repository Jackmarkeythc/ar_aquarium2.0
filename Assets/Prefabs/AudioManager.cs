using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource currentAudioSource;

    public void PlayAudioClip(AudioSource audioSource)
    {
        if (currentAudioSource != null && currentAudioSource.isPlaying)
        {
            currentAudioSource.Stop();
            Debug.Log("Stopped previous audio source.");
        }

        currentAudioSource = audioSource;
        currentAudioSource.Play();
        Debug.Log("Playing new audio source.");
    }
}
