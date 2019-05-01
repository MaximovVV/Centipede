using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject PieceCentipede;
	public GameObject HeadCentipede;
	public float RespawnTime = 15;
	private float RespawnTimer;
    private Vector3 pos;
	public int MaxSize = 8;
	int Size;
	List<GameObject> body = new List<GameObject>(); //we need a whole list of the centipede being created

    void Start () {
        pos = transform.position;
        pos.y = Camera.main.orthographicSize - 0.05f;
        transform.position = pos;
    }	

	void GetSize()
	{
		Size = Random.Range (1, MaxSize);
    }


	void Spawn()
	{
		GetSize (); //get the length of the centipede
        CreateBody ();  //allocate memory and fill the list with centipede pieces

        body[0] = Instantiate (HeadCentipede, transform.position, transform.rotation); //create the first piece that will be the head

        for (int i = 1; i < Size; i++) {
			body[i] = Instantiate (PieceCentipede, transform.position, transform.rotation); //First fill in the list completely 
            PieceCentipede piece = body[i].GetComponent<PieceCentipede> ();                 //with initialized pieces.
            piece.Initialize (body[i-1]);                                                   //Pointing each piece to following piece him
        }
        for (int i = 1; i < Size; i++)
        {
            PieceCentipede piece = body[i].GetComponent<PieceCentipede>();                  //Pointing each piece to previous piece of him
            piece.InitializePrevious(body[i + 1]);
        }
        body.Clear ();

	}


	void CreateBody()
	{
		for (int i = 0; i < Size; i++) {
			body.Add(new GameObject());  //allocate memory and fill the list with centipede pieces
        }
	}

	void SpawnPiece()
	{
		
	}
	// Update is called once per frame
	void Update () {
		RespawnTimer -= Time.deltaTime;

		if (RespawnTimer <= 0) {
			RespawnTimer = RespawnTime;
			Spawn();

		}
	}
}
