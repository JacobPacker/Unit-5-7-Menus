using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [HideInInspector]
    public float musicVolume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMusicVolume(float inputValue)
    {
        musicVolume = inputValue;
    }

    public float GetMusicVolume()
    {
        return musicVolume;
    }
}
