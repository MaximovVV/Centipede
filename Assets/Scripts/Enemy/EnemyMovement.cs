using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float BaseMoveSpeed = 15f;
	static float ShipRadius = 0.2f;
	private float screenRatio = (float)Screen.width / (float)Screen.height;
	Vector3 pos;


	// Use this for initialization
	void Start () {
        if(Random.Range(0,2)==0) //direction choice
            transform.eulerAngles = new Vector3(0, 0, 90); 
        else transform.eulerAngles = new Vector3(0, 0, 270);
        pos = transform.position;
	}


	// Update is called once per frame
	void Update () {

        Vector3 velocity = new Vector3(0, BaseMoveSpeed * Time.deltaTime, 0);
        float withOrtho = Camera.main.orthographicSize * screenRatio;
		pos += transform.rotation * velocity ;


		if (pos.x + ShipRadius > withOrtho) {
			pos.x = withOrtho - ShipRadius;
			Rotates ();
		}

		if (pos.x - ShipRadius < -withOrtho) {
		pos.x = -withOrtho + ShipRadius;
			Rotates ();
		}

        if (pos.y < -Camera.main.orthographicSize)
            LifePointer.SubLifePoint();    //Taking away a life point
        transform.position = pos;
		
	}

	void Rotates()
	{
        pos.y -= 0.3f;
        transform.Rotate(0,0,180);

	}

	void OnTriggerEnter2D(Collider2D otherObject)
	{
		{
			if (otherObject.gameObject.layer == 10 || otherObject.gameObject.layer == 11) { //10 = Stone, 11 = Head(of centipede)
				Rotates ();
			}
		}
	}
}
