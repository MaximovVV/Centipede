using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAteroids : MonoBehaviour { //asteroid generation all over the map

    public GameObject Asteroid1, Asteroid2, Asteroid3, AsteroidBonus; //create a variety of asteroids
    private int countCellVertical, countCellHorizontal; // The value of the matrix which will generate asteroids
    private int  random; //for random generation (percentage value)
    private float screenRatio = (float)Screen.width / (float)Screen.height;
    private Vector3 pos;
    public float divider = 0.5f; //divider of map with which we get the matrix
    float withOrtho;

    void Start () {
        Spawn();
	}


    void Spawn()
    {
        GetCountCells();

        for (int i = -countCellVertical / 2 * 3 / 6; i <= countCellVertical / 2 * 9 / 10; i++) //traversal of each row
            for (int y = -countCellHorizontal / 2; y <= countCellHorizontal / 2; y++) //traversal of each column
            {
                pos.y = divider * i + Camera.main.transform.position.y; //getting the positions
                pos.x = divider * y + Camera.main.transform.position.x; // of each cell
                random = Random.Range(0, 100);
                if (random >= 0 && random <= 5) //and creation with a probability of 5 percent
                    Instantiate(Asteroid1, pos, transform.rotation);
                else if (random >= 6 && random <= 10) //creation with a probability of 5 percent
                    Instantiate(Asteroid2, pos, transform.rotation);
                else if (random >= 11 && random <= 12) //creation with a probability of 2 percent
                    Instantiate(Asteroid3, pos, transform.rotation);
                else if (random == 99) //creation with a probability of 1 percent !!!
                    Instantiate(AsteroidBonus, pos, transform.rotation);
            }
    }

    void GetCountCells() //break the map into a matrix of cells by using divider
    {
        countCellVertical = (int)(Camera.main.orthographicSize * 2/ divider);
        withOrtho = Camera.main.orthographicSize * screenRatio;
        countCellHorizontal = (int)(screenRatio * withOrtho / divider);
    }

}
