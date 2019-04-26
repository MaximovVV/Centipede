using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	public GameObject fireObject;
    private bool bonus; //flag of bonus
	public float coolDownDelay = 0.1f;
	private float coolDownTimer = 0;
    private float bonusTime = 10;
    private float bonusTimer;


    public void SetBonus()
    {
        bonus = true;
        bonusTimer = bonusTime;
    }

	void Update () {
		coolDownTimer -= Time.deltaTime;    

		if (Input.GetKeyDown(KeyCode.Space) && coolDownTimer <= 0)
		{
			coolDownTimer = coolDownDelay;
            SoundManager.PlaySound("blaster");

            Instantiate(fireObject, transform.position, transform.rotation); //creating fire of blaster

            if(bonus) //creating fire of blaster with bonus (triple shot)
            {
                bonusTimer -= Time.deltaTime*20;

                Instantiate(fireObject, transform.position,Quaternion.Euler(0,0,45));
                Instantiate(fireObject, transform.position, Quaternion.Euler(0, 0, -45));

                if (bonusTimer < 0)
                    this.bonus = false;
            }
		}

		
	}
}
