using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectedPenalty : MonoBehaviour
{
    private void Awake()

    {

        var obj = FindObjectsOfType<SelectedPenalty>();

        if (obj.Length == 1)

        {

            DontDestroyOnLoad(gameObject);

        }

        else

        {

            Destroy(gameObject);

        }

    }

}
