using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerScript : MonoBehaviour
{
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.GetComponent<Button>().Select();
        //PlaySound();
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*void PlaySound()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
           // FindObjectOfType<AudioManager>().Play("select");
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
           // FindObjectOfType<AudioManager>().Play("select");
        }
    }*/
}
