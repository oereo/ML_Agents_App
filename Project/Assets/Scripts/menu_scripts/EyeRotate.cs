using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EyeRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public void cardOn()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("GM");
        temp.GetComponent<RandomPicker>().isPlayingCard = true;

    }

    public void cardOff()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("GM");
        temp.GetComponent<RandomPicker>().isPlayingCard = false;

    }
}
