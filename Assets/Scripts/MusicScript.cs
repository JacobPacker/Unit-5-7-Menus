using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    public void MusicSliderChanged( float newValue )
    {
        print("value changed to " + newValue);
        PlayerPrefs.SetFloat("musicVol", newValue);


    }
}
