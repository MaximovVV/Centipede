using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometMovement : MonoBehaviour {

    public GameObject Asteroid1;
    public float RespawnStoneTime = 0.2f;
    private float RespawnStoneTimer;
    private float BaseMoveSpeed = 3f;
	// Use this for initialization
	void Start () {
        transform.eulerAngles = new Vector3(0, 0, 180);
        transform.Rotate(0, 0, Random.Range(-20,20));
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, BaseMoveSpeed * Time.deltaTime, 0);

        pos += transform.rotation * velocity;
        transform.position = pos;

        RespawnStoneTimer -= Time.deltaTime;

        if (RespawnStoneTimer <= 0)
        {
            RespawnStoneTimer = RespawnStoneTime;
            Instantiate(Asteroid1, transform.position, transform.rotation);
        }
    }
}
