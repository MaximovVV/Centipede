using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMovement : MonoBehaviour {

    public float BaseMoveSpeed = 1f;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, BaseMoveSpeed * Time.deltaTime, 0);

        pos += transform.rotation * velocity;
        transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        {
            if (otherObject.gameObject.layer == 13)
                Destroy(gameObject);
        }
    }
}
