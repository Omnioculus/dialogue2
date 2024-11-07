using UnityEngine;

public abstract class AudioController : MonoBehaviour
{
    public void InitializeSound(Sound sound)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        sound.Initialize(audioSource);
    }

    public abstract void OnPause();

    public abstract void OnUnPause();
}