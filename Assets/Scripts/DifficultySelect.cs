using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultySelect : MonoBehaviour
{
    
    public GameObject changingTextTwo;
    bool easy = true;
    bool medium = false;
    bool hard = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (easy = true)
        {

        }
    }
    public void Easy()
    {
        easy = true;
        medium = false;
        hard = false;
    }
    public void Medium()
    {
        easy = false;
        medium = true;
        hard = false;
    }
    public void Hard()
    {
        easy = false;
        medium = false;
        hard = true;
    }
    public void TextChange()
    {
        if (easy = true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Easy";
        }
        if (medium = true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Medium";
        }
        if (hard = true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Hard";
        }
    }
}
