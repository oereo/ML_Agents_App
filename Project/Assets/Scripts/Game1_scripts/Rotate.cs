using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float turnspeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, turnspeed * Time.deltaTime, 0f);
    }
}
