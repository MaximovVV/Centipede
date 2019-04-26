using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnComet : MonoBehaviour
{


    public GameObject Comet, Comet2; //initialization of all types of comets
    private float screenRatio = (float)Screen.width / (float)Screen.height;
    private Vector3 pos;
    public float RespawnTime = 20;
    public float RespawnStoneTime = 2;
    private float RespawnTimer;
    private float withOrtho;

    void Start()
    {
        RespawnTimer = RespawnTime;
        withOrtho = Camera.main.orthographicSize * screenRatio;
    }

    void Spawn()
    {
        pos.x = Random.Range(-withOrtho, withOrtho);
        pos.y = Camera.main.orthographicSize;
        Instantiate(Comet, pos, transform.rotation);    //creating a group of comets 
        pos.x += Random.RandomRange(2, 4);              //at a distance from each other
        Instantiate(Comet2, pos, transform.rotation);
        pos.x -= Random.RandomRange(2, 4)*2;
        Instantiate(Comet2, pos, transform.rotation);
        SoundManager.PlaySound("comet");

    }

    void Update()
    {
        RespawnTimer -= Time.deltaTime;

        if (RespawnTimer <= 0)
        {
            RespawnTimer = RespawnTime;
            Spawn();
        }
    }
}
