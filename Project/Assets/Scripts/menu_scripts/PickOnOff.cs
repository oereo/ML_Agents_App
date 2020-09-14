using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickOnOff : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject[] temp;
    public void resetJebi()
    {
        
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i].SetActive(true);
            
        }

    }
}
