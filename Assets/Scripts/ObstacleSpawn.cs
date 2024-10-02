using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject Obstacle;
    public float minX;
    public float maxX;  
    public float minY;  
    public float maxY;
    public float timebetweenSpawn;
    private float SpawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + timebetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(Obstacle , transform.position + new Vector3(randomX, randomY, 0) , transform.rotation);
    }


}
