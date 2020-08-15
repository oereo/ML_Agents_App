using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RandomPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public List<int> BlueCard = new List<int>();
    public List<int> RedCard = new List<int>();
    public int BlueScore;
    public int RedScore;


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



}
