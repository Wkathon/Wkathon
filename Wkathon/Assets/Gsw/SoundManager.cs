using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    // Start is called before the first frame update
    private void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }
}
