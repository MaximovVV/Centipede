using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceCentipede : MonoBehaviour  {


	public GameObject Head; //to create a head game object
    public GameObject NextPiece, PreviousPiece; //links to the next and previous pieces in the body
    public float PieaceDiameter = 0.3f;


	void Start()
	{
		
	}

	public void Initialize(GameObject nextPiece)
	{
		this.NextPiece = nextPiece;
	}

	public void InitializePrevious(GameObject previousPiece)
	{
		this.PreviousPiece = previousPiece;
	}




	void Update()
	{
		if (NextPiece != null) { 
			Vector2 direction = (gameObject.transform.position - NextPiece.transform.position).normalized; //direction to the next
            float distance = (gameObject.transform.position - NextPiece.transform.position).magnitude; //distance to the next

            float zAngle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90;
			gameObject.transform.rotation = Quaternion.Euler (0, 0, zAngle);

			if (distance > PieaceDiameter) {
				gameObject.transform.position = Vector2.Lerp (gameObject.transform.position, NextPiece.transform.position, Time.deltaTime * 12); //Following the next
            }  
			}
        if (NextPiece == null)
        {
            transform.Rotate(0, 0, 90);
            NextPiece = Instantiate(Head, transform.position, transform.rotation); //creating new head of new centipede

        }
    }


	void OnTriggerEnter2D(Collider2D otherObject)
	{
		{
			if (otherObject.gameObject.layer == 8) {
               
                Destroy(gameObject);
			}
		}
	}
}










