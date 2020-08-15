using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlqyer_Random : MonoBehaviour
{

    public GameObject playersBlue;
    public GameObject playersBlue1;
    public GameObject playersPurple;
    public GameObject playersPurple1;
    // Start is called before the first frame update
    void Start()
    {
        float xPos = Random.Range(-10, 10);
        float zPos = Random.Range(-10, 10);
        playersBlue.transform.position = new Vector3(xPos, 0, zPos);
        playersBlue1.transform.position = new Vector3(xPos, 0, zPos);
        playersPurple.transform.position = new Vector3(xPos, 0, zPos);
        playersPurple1.transform.position = new Vector3(xPos, 0, zPos);

        //Vector3 playersPos = new Vector3(xPos, 0, zPos);
        //Instantiate(players, playersPos, players.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
