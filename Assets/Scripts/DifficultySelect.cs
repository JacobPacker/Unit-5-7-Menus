using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultySelect : MonoBehaviour
{
    
    public GameObject changingTextTwo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Easy()
    {
        changingTextTwo.GetComponent<Text>().text = "Difficulty: Easy";
    }
    public void Medium()
    {
        changingTextTwo.GetComponent<Text>().text = "Difficulty: Medium";
    }
    public void Hard()
    {
        changingTextTwo.GetComponent<Text>().text = "Difficulty: Hard";
    }
    /*public void TextChange()
    {
        if (easy == true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Easy";
        }
        if (medium == true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Medium";
        }
        if (hard == true)
        {
            
            changingTextTwo.GetComponent<Text>().text = "Difficulty: Hard";
        }
    }*/
}
