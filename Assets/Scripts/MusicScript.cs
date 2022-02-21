using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    [HideInInspector]
    public float musicVolume;

    public void SetMusicVolume(float inputValue)
    {
        musicVolume = inputValue;
    }

    public float GetMusicVolume()
    {
        return musicVolume;
    }
}
