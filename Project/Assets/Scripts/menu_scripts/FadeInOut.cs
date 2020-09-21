using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeInOut : MonoBehaviour
{
    public RawImage IMG1;
    public RawImage IMG2;
    public RawImage IMG3;
    int k = 1;
    float a = 1f;
    Color temp;
    float t = 0f;
    // Update is called once per frame
    void Update()
    {
        
        if (k==1)
        {
            if (a > 0f && t > 5f)
            {
                a-=(Time.deltaTime/2f);
                IMG1.color = new Color(IMG1.color.r, IMG1.color.g, IMG1.color.b, a);
              
            }
            else if(a>0f&&t<=5f)
            {
                t += Time.deltaTime;
            }
            else { k = 2; a = 1f; t = 0f; }
        }
        else if (k == 2)
        {
            if (a > 0f&&t>5f)
            {
                a -= (Time.deltaTime/2f);
                IMG2.color = new Color(IMG2.color.r, IMG2.color.g, IMG2.color.b, a);
            }
            else if (a > 0f && t <= 5f)
            {
                t += Time.deltaTime;
            }
            else { k = 3; a = 1f; t = 0f; }

        }
        else if (k == 3)
        {
            if (a > 0f && t > 5f)
            {
                a -= (Time.deltaTime/2f);
                IMG3.color = new Color(IMG3.color.r, IMG3.color.g, IMG3.color.b, a);
            }
            else if (a > 0f && t <= 5f)
            {
                t += Time.deltaTime;
            }
            else {
                k =1;
                IMG1.color = new Color(IMG1.color.r, IMG1.color.g, IMG1.color.b, 255f);
                IMG2.color = new Color(IMG2.color.r, IMG2.color.g, IMG2.color.b, 255f);
                IMG3.color = new Color(IMG3.color.r, IMG3.color.g, IMG3.color.b, 255f);
                a = 1f;
                t = 0f;
            }

        }


    }
}
