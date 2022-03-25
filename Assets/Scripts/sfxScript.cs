using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sfxScript : MonoBehaviour
{
    public void SfxSliderChanged( float newValue )
    {
        //print("value changed to " + newValue);
        PlayerPrefs.SetFloat("sfxVol", newValue);
    }
}
