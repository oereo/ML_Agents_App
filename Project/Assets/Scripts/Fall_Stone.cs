using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Stone : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject stone;
    private float startTime = 1;
    private float repeatTime = 0.15f;

    private void Start()
    {
        InvokeRepeating("Spawn", startTime, repeatTime);
    }

    void Update()
    {
        
    }

    private void Spawn()
    {
        float xPos = Random.Range(-440, -520);
        float zPos = Random.Range(-290, -330);
        Vector3 stonePos = new Vector3(xPos, 30, zPos);
        Instantiate(stone, stonePos, stone.transform.rotation);
    }   
    //Vector3[] positions = new Vector3[5];
    //public GameObject stone;
    //public bool isSpawn = false;

    //public float spawnDelay = 2.0f;
    //float spawnTimer = 0f;


    //void Start()
    //{
    //    CreatePosition();        
    //}

    //void CreatePosition()
    //{
    //    float viewPosY = 10f;
    //    float gapX = 1f / 6f;
    //    float viewPosX = -471f;
    //    float viewPosz = -309f;

    //    for (int i = 0; i<positions.Length; i++)
    //    {
    //        viewPosY = gapX + gapX * i;
    //        Vector3 viewPos = new Vector3(viewPosX, viewPosY,viewPosz);
    //        Vector3 WorldPos = Camera.main.ViewportToWorldPoint(viewPos);
    //        positions[i] = WorldPos;
    //    }
    //}

    //void SpawnStone()
    //{
    //    if(isSpawn == true)
    //    {
    //        if(spawnTimer > spawnDelay)
    //        {
    //            int rand = Random.Range(0, positions.Length);
    //            Instantiate(stone, positions[rand], Quaternion.identity);
    //            spawnTimer = 0f;

    //        }
    //        spawnTimer += Time.deltaTime;
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    SpawnStone();
    //}
}
