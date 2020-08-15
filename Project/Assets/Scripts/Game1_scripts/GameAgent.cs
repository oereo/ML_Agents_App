using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameAgent : MonoBehaviour
{
   
    public List<GameObject> gameOptions = new List<GameObject>();
     GameObject temp;
    public Text p;
    public int Blue;
    public int Red;
    void Awake()
    {
        int rand = Random.Range(0, gameOptions.Count);
        temp = GameObject.FindGameObjectWithTag("GM");
        gameOptions[rand].SetActive(true);  
        Blue = temp.GetComponent<RandomPicker>().BlueScore;
        Red = temp.GetComponent<RandomPicker>().RedScore;
     
      //  Destroy(GameObject.FindGameObjectWithTag("GM"));
    }


    public void pickGame()
    {
        int rand = Random.Range(0, gameOptions.Count);
        gameOptions[rand].SetActive(true);
    }

    public void MoveMenu()
    {
        SceneLoader.Instance.LoadScene("menu");
    }

}
