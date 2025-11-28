using UnityEngine;

public class ObjectPlacementScript : MonoBehaviour
{
    AudioManager audioManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioManager = FindFirstObjectByType<AudioManager>();
        audioManager.PlayAudioClip(GetComponent<AudioSource>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
