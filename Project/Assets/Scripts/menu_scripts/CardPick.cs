using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardPick : MonoBehaviour
{

    public int team;
    public int num;
    GameObject manager;
    public Text whichPick;
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

    public void showPick()
    {

        whichPick.text = num.ToString();
  
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
