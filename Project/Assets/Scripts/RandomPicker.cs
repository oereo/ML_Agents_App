﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public List<string> GatchaList1 = new List<string>();
    public List<string> GatchaList2 = new List<string>();
    public List<string> GatchaList3 = new List<string>();
    public Text penaltyDescription1;
    public Text penaltyDescription2;
    public Text penaltyDescription3;
    public void GatchaWho()
    {
        int rand = Random.Range(0, GatchaList1.Count);
        penaltyDescription1.text = GatchaList1[rand];
        GatchaList1.RemoveAt(rand);
    }

    public void GatchaToDO1()
    {
        int rand = Random.Range(0, GatchaList2.Count);
        penaltyDescription2.text = GatchaList2[rand];
        GatchaList2.RemoveAt(rand);
    }

    public void GatchaToDo2()
    {
        int rand = Random.Range(0, GatchaList3.Count);
        penaltyDescription3.text = GatchaList3[rand];
        GatchaList3.RemoveAt(rand);
    }



}
