using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EyeRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnspeed = 160f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f,turnspeed * Time.deltaTime);
    }
}
