using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Random_Generation_V2 : MonoBehaviour
{
    public GameObject room, corridor;

    public int chanceToSpawn, roomsGenerate;

    public static int  roomsSpawn;

    void Start()
    {
        for (int i = -2; i < 2; i ++)
        {

            if (Random.Range(0, 1000) < chanceToSpawn && roomsSpawn < roomsGenerate)
            {
                roomsSpawn ++;

                GameObject cor = Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));

                Transform[] yes = cor.GetComponentsInChildren<Transform>();

                Instantiate(room, yes[1].position, Quaternion.Euler(0, 0, i * 90));
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
