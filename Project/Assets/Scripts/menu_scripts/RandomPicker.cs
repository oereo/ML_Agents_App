using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RandomPicker : MonoBehaviour
{
    /* Start is called before the first frame update
    public List<int> BlueCard = new List<int>();
    public List<int> RedCard = new List<int>();
    public int BlueScore;
    public int RedScore;
    public int B_textSc=0;
    public int R_textSc=0;
    public bool isPlayingCard = false;
    public bool isGM = true;
   
    //manager = GameObject.FindGameObjectWithTag("GM");
    public void Update()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("con");
        if (temp)
        {
            
            if (isGM)
            {
                if (!isPlayingCard && temp)
                {
                    temp.SetActive(false);
                }

            }
        }
    }

    public void cardOff()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("GM");
        temp.GetComponent<RandomPicker>().isPlayingCard = false;

    }
 

    public void Reset()
    {
        B_textSc = 0; 
        R_textSc = 0;
        GameObject[] tempB = GameObject.FindGameObjectsWithTag("bs");
        GameObject[] tempR = GameObject.FindGameObjectsWithTag("rs");
        for (int i = 0; i < tempB.Length; i++)
        {
            tempB[i].GetComponent<Text>().text = B_textSc.ToString();
            tempR[i].GetComponent<Text>().text = R_textSc.ToString();
        }
        BlueCard.Clear();
       RedCard.Clear();
        for (int i = 1; i <= 7; i++)
        {
            BlueCard.Add(i);
            RedCard.Add(i);
        }
    }

    public void BluePick(int num)
    {
        BlueScore = num;
        int index = BlueCard.IndexOf(num);
        BlueCard.RemoveAt(index);
    }

    public void RedPick(int num)
    {
        RedScore = num;
        int index = RedCard.IndexOf(num);
        RedCard.RemoveAt(index);
    }
    */
    public void MoveGame2()
    {
        SceneLoader.Instance.LoadScene("SoccerTwos");
    }

    public void MoveGame1()
    {
        SceneLoader.Instance.LoadScene("WalkerStatic");
    }

}
