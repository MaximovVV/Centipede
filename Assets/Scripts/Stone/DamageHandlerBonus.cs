using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerBonus : DamageHandler {

    // Use this for initialization
    public GameObject Bonus;

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.layer == 13 || otherObject.gameObject.layer == 8)
        {
            health--;
        }
    }
    // Use this for initialization
    public override void Die()
    {
        SoundManager.PlaySound("stone");
        transform.Rotate(0, 0, 180);
        Instantiate(Bonus, transform.position, transform.rotation);
        Score.AddScore(20);
        Destroy(gameObject);
       
    }
}
