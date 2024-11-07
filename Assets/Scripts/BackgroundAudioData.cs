using UnityEngine;

[CreateAssetMenu(fileName = "BackgroundAudioData", menuName = "Scriptable Objects/BackgroundAudioData")]
public class BackgroundAudioData : ScriptableObject
{
    public Sound BackgroundMusic;
    // Volume to set background music when player is in "Instrument" state
    [Range (0f, 1f)]
    public float BackgroundMusicInstrumentVolume;
    // Volume to set background music when game is paused
    [Range (0f, 1f)]
    public float BackgroundMusicPauseVolume;
}
