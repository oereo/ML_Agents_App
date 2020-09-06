using UnityEngine;
using UnityEngine.UI;
public class SoccerBallController : MonoBehaviour
{
    [HideInInspector]
    public SoccerFieldArea area;
    public string purpleGoalTag; //will be used to check if collided with purple goal
    public string blueGoalTag; //will be used to check if collided with blue goal
    public GameObject finishUI;
    public GameObject before;
    public GameObject after;
    public Text winner;
    public Text B1;
    public Text R1;
    public Text B2;
    public Text R2;
    bool check = false;
   
    void OnCollisionEnter(Collision col)
    {
        if (!check)
        {
           
                if (col.gameObject.CompareTag(purpleGoalTag)) //ball touched purple goal
                {
                    int score = int.Parse(B1.text);
                    score++;
                    B1.text = score.ToString();
                    B2.text = B1.text;
                    check = true;
                    area.GoalTouched(AgentSoccer.Team.Blue);
                    int Bs = int.Parse(B1.text);
                    int Rs = int.Parse(R1.text);
                    if (Rs == 2)
                    {
                        finishUI.SetActive(true);
                        winner.text = "Red";
                    }
                    else if (Bs == 2)
                    {
                       finishUI.SetActive(true);
                        winner.text = "Blue";
                    }
                    else
                    {
                        after.SetActive(true);
                        before.SetActive(false);
                    }

                }
                if (col.gameObject.CompareTag(blueGoalTag)) //ball touched blue goal
                {
                    int score = int.Parse(R1.text);
                    score++;
                    R1.text = score.ToString();
                    R2.text = R1.text;
                    check = true;
                    area.GoalTouched(AgentSoccer.Team.Purple);
                    int Bs = int.Parse(B1.text);
                    int Rs = int.Parse(R1.text);
                    if (Rs == 2)
                    {
                        
                        finishUI.SetActive(true);
                        winner.text = "Red";
                    }
                    else if (Bs == 2)
                    {
                        
                        finishUI.SetActive(true);
                        winner.text = "Blue";
                    }
                    else
                    {
                        after.SetActive(true);
                        before.SetActive(false);
                    }

                }

            
        }
    }
}
