using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BR_Score : MonoBehaviour
{
    public bool isBlue;
    // Start is called before the first frame update
    void Start()
    {
        if(isBlue)
        {
            gameObject.GetComponent<Text>().text = GameObject.FindGameObjectWithTag("GM").GetComponent<RandomPicker>().B_textSc.ToString();
        }
        else
        {
            gameObject.GetComponent<Text>().text = GameObject.FindGameObjectWithTag("GM").GetComponent<RandomPicker>().R_textSc.ToString();
        }
        
    }

   
}
