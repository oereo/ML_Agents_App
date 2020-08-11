using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectedPenalty : MonoBehaviour
{
    public Text penalty;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    
}
