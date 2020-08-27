using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardPick : MonoBehaviour
{

    public int team;
    public int num;
    GameObject manager;
   
  //  public GameObject pickBut;

    public void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GM");
        if (team == 0)
        {
            if (!manager.GetComponent<RandomPicker>().BlueCard.Contains(num))
            {
                gameObject.SetActive(false);
               
            }
        }
        else
        {
            if (!manager.GetComponent<RandomPicker>().RedCard.Contains(num))
            {
                gameObject.SetActive(false);
            }

        }
    }
    
    public void hideB()
    {
        GameObject[] obj3 = GameObject.FindGameObjectsWithTag("GS");
        for (int i = 0; i < obj3.Length; i++)
        { obj3[i].SetActive(false); }

    }

    public void Blue()
    {
        manager.GetComponent<RandomPicker>().BluePick(num);
    }

    public void Red()
    {
        manager.GetComponent<RandomPicker>().RedPick(num);
    }
    public void MoveGame1()
    {
        SceneLoader.Instance.LoadScene("WalkerStatic");
    }


}
