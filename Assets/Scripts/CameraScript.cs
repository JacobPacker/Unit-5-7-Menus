using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera MainCamera;
    public Camera GameCamera;

    void Start()
    {
        MainCamera.enabled = true;
        GameCamera.enabled = false;
    }

    public void ShowGameView()
    {
        MainCamera.enabled = false;
        GameCamera.enabled = true;
    }

    
    public void ShowMainView()
    {
        MainCamera.enabled = true;
        GameCamera.enabled = false;
    }

}
