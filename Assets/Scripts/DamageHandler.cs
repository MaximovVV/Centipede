using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

	public int health = 1;
		
	void Update () {
		if (health <= 0) {
			Die ();
		}
	}

	public virtual void Die()
	{
		Destroy(gameObject);
	}
}
