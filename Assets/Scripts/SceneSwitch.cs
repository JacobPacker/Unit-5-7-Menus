using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
    public void DummyScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("rpgpp_lt_scene_1.0");
    }
}
