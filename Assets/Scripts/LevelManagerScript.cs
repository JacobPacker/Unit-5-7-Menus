using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class LevelManagerScript : MonoBehaviour
{
    public GameObject Button;
    public AudioManager audioManager;
    public Slider musicSliderVol;
    public Slider sfxSliderVol;

    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

        musicSliderVol.value = PlayerPrefs.GetFloat("musicVol");
        sfxSliderVol.value = PlayerPrefs.GetFloat("sfxVol");


        Button.GetComponent<Button>().Select();

        print("load menu");

        float musicVol = 1;// PlayerPrefs.GetFloat("musicVol");
        print("stored music vol " + musicVol);

        float sfxVol = PlayerPrefs.GetFloat("sfxVol");
        print("stored sfx vol " + sfxVol);

        audioManager.PlayMusic("music");


        // get the stored sfx volume from playerprefs 

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayClick()
    {
        audioManager.Play("1");
    }
    public void OnMouseOver()
    {
        audioManager.Play("2");
    }

    public void OnMouseExit()
    {
        audioManager.Play("2");
    }
}
