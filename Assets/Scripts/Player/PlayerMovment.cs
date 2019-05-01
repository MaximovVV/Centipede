using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

	public float BaseMoveSpeed = 8f;
	private float ShipRaius = 0.24f;
    private float BorderPlayer;
    float withOrtho;
    private float screenRatio = (float)Screen.width / (float)Screen.height;

	// Use this for initialization
	void Start () {
        BorderPlayer = Camera.main.orthographicSize  * 0.5f;
        withOrtho = Camera.main.orthographicSize * screenRatio;
    }

	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
		
		pos.x += BaseMoveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime;
        pos.y += BaseMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        if (pos.x + ShipRaius > withOrtho) {
			pos.x = withOrtho - ShipRaius;
		}

		if (pos.x - ShipRaius < -withOrtho) {
			pos.x = -withOrtho + ShipRaius;
		}


        if (pos.y + ShipRaius > BorderPlayer - Camera.main.orthographicSize)
        {
            pos.y = BorderPlayer - ShipRaius - Camera.main.orthographicSize;
        }

        if (pos.y - ShipRaius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + ShipRaius;
        }

        transform.position = pos;


	}
}
