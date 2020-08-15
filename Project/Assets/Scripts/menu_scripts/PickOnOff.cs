using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Card = new List<GameObject>();
   public void OnOff()
    {

        for(int i=0;i<Card.Count;i++)
        {
            Card[i].SetActive(false);

        }
    }
}
