using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class resetPick : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Bs;
    public Text Rs;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetJebi()
    {
        int iCount = gameObject.transform.childCount;
        for (int i = 0; i < iCount; i++)
        {
            Transform trChild = gameObject.transform.GetChild(i);
            trChild.gameObject.SetActive(true);
        }

    }


    public void ResetCard()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("GM");
        temp.GetComponent<RandomPicker>().Reset();
        Bs.text = "0";
        Rs.text = "0";
        int iCount = gameObject.transform.childCount;
        for (int i = 0; i < iCount; i++)
        {
            Transform trChild = gameObject.transform.GetChild(i);
            trChild.gameObject.SetActive(true);
        }
    }


}
