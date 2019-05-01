using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageNandlerAsteroid : DamageHandler {

	public GameObject newAsteroid;

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		if(otherObject.gameObject.layer == 13)
		{
			health--;
		}
	}
	// Use this for initialization
	public override void Die()
	{
        SoundManager.PlaySound("stone");
		Destroy(gameObject);
		Instantiate(newAsteroid, transform.position, transform.rotation);
        Score.AddScore(1);
    }
}
