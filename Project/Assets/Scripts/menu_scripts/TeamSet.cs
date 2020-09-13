using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeamSet : MonoBehaviour
{
    public Text RedScore;
    public Text BlueScore;
    public Text YellowScore;
    public Text GreenScore;

    public void blueUp()
    {
        int s = int.Parse(BlueScore.text);
        s += 1;
        BlueScore.text = s.ToString();

    }

    public void blueDown()
    {
        int s = int.Parse(BlueScore.text);
        s -= 1;
        BlueScore.text = s.ToString();
    }

    public void RedUp()
    {
        int s = int.Parse(RedScore.text);
        s += 1;
        RedScore.text = s.ToString();
    }

    public void RedDown()
    {
        int s = int.Parse(RedScore.text);
        s -= 1;
        RedScore.text = s.ToString();
    }

    public void YellowUp()
    {
        int s = int.Parse(YellowScore.text);
        s += 1;
        YellowScore.text = s.ToString();
    }
    public void YellowDown()
    {
        int s = int.Parse(YellowScore.text);
        s -= 1;
        YellowScore.text = s.ToString();
    }

    public void GreenUp()
    {
        int s = int.Parse(GreenScore.text);
        s += 1;
        GreenScore.text = s.ToString();
    }

    public void GreenDown()
    {
        int s = int.Parse(GreenScore.text);
        s -= 1;
        GreenScore.text = s.ToString();
    }



}
