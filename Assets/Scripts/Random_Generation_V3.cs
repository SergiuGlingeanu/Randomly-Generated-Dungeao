using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Random_Generation_V3 : MonoBehaviour
{
    public GameObject room;

    public int maxRooms;

    public float spaceBetweenRooms, chacneToSpawn;

    void Start()
    {
        for (int i = -1; i < 2; i += 2)
        {
            if (Random_Generation_V2.roomsSpawn < maxRooms && Random.Range(0, 1000) < chacneToSpawn)
            {
                Instantiate(room, transform.position += new Vector3(i * spaceBetweenRooms, 0, 0), Quaternion.identity);

                Random_Generation_V2.roomsSpawn++;
            }
        }

        for (int i = -1; i < 2; i += 2)
        {
            if (Random_Generation_V2.roomsSpawn < maxRooms && Random.Range(0,1000) < chacneToSpawn)
            {
                Instantiate(room, transform.position += new Vector3(0, i * spaceBetweenRooms, 0), Quaternion.identity);

                Random_Generation_V2.roomsSpawn++;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(0);
        }
    }
}
