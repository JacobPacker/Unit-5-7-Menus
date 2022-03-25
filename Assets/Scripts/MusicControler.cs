using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControler : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool isMuted;
    void Start()
    {
        isMuted = false;
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("BgmVolume", volume);
    }
    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}
