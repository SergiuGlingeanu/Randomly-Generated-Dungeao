using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Generation_V2 : MonoBehaviour
{
    public GameObject room, corridor;

    public int chanceToSpawn, roomsGenerate;

    public static int  roomsSpawn;

    private Vector2 _direction;

    void Start()
    {
        Invoke("Generate", 1);
    }

    private void GetDirection(float x)
    {
        switch(x)
        {
            case -2:
                _direction = new Vector2(-1, 0);
                break;
            case -1:
                _direction = new Vector2(0, -1);
                break;

            case 0:
                _direction = new Vector2(1, 0);
                break;

            case 1:
                _direction = new Vector2(0, 1);
                break;
        }
    }

    private void Generate()
    {
        for (int i = -2; i < 2; i++)
        {

            if (Random.Range(0, 1000) < chanceToSpawn && roomsSpawn < roomsGenerate)
            {
                GetDirection(i);
                if (!Physics.Raycast(transform.position, _direction, 100f))
                {
                    roomsSpawn++;

                    GameObject cor = Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));

                    Transform[] yes = cor.GetComponentsInChildren<Transform>();

                    Instantiate(room, yes[1].position, Quaternion.Euler(0, 0, 0));
                }
            }
        }
    }
}
