using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardFlip : MonoBehaviour
{
    public float turnspeed = 750f;
    public GameObject flip;
    bool rot = false;
    float rtt = 0f;
  

    // Update is called once per frame
    void Update()
    {
        if(rot)
        {
          
            if (rtt >= 600)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                flip.SetActive(true);
                rot = false;
                gameObject.SetActive(false);
                rtt = 0;
            }
            else
            {
                rtt += (turnspeed/50f);
                transform.Rotate(0f, turnspeed * Time.deltaTime, 0f);
            }
        }
        
    }

    public void Rot()
    {
        rot = true;
    }

}
