using UnityEngine;
using UnityEngine.UI;
public class SoccerBallController : MonoBehaviour
{
    [HideInInspector]
    public SoccerFieldArea area;
    public string purpleGoalTag; //will be used to check if collided with purple goal
    public string blueGoalTag; //will be used to check if collided with blue goal
    public GameObject finishUI;
    public Text winner;
    bool check = false;
    void OnCollisionEnter(Collision col)
    {
        if (!check)
        {
            if (col.gameObject.CompareTag(purpleGoalTag)) //ball touched purple goal
            {
                check = true;
                finishUI.SetActive(true);
                area.GoalTouched(AgentSoccer.Team.Blue);
                winner.text = "Red";
    
            }
            if (col.gameObject.CompareTag(blueGoalTag)) //ball touched blue goal
            {
                check = true;
                finishUI.SetActive(true);
                area.GoalTouched(AgentSoccer.Team.Purple);
                winner.text = "Blue";
            }
        }
    }
}
