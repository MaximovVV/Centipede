using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerEnemy : DamageHandler {

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter2D(Collider2D otherObject)
	{
		{
            if (otherObject.gameObject.layer == 13 || otherObject.gameObject.layer == 8)
            {
                SoundManager.PlaySound("death");
                Destroy(gameObject);
                Score.AddScore(10);
            }
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
