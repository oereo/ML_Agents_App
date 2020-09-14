using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTar : MonoBehaviour
{

    public GameObject tar;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = tar.transform.position;
    }
}
