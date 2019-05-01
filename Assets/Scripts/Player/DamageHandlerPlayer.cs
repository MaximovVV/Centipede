using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerPlayer : DamageHandler {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D otherObject)
    {
		{
            if (otherObject.gameObject.layer == 9 || otherObject.gameObject.layer == 11 || otherObject.gameObject.layer == 12)
                LifePointer.SubLifePoint();
            else if (otherObject.gameObject.layer == 14)
            {
                PlayerShooting bonus = GetComponent<PlayerShooting>();
                bonus.SetBonus();
                SoundManager.PlaySound("bonus");
            }
        }
	}
}
