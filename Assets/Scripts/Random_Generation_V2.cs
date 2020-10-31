using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Generation_V2 : MonoBehaviour
{
    public GameObject room, corridor;

    public int chanceToSpawn, roomsGenerate, minRooms, rayLenght, roomThiccness;

    public float secs;

    public static int  roomsSpawn;

    private Vector2 _direction, _startPos;

    void Start()
    {
        Invoke("Generate", secs);
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
            if (roomsSpawn < minRooms)
            {
                GetDirection(i);
                _startPos = (Vector2)transform.position + (_direction * roomThiccness);

                if (!Physics2D.Raycast(_startPos, _direction, rayLenght))
                {
                    roomsSpawn++;
                    GameObject cor = Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));
                    Transform[] yes = cor.GetComponentsInChildren<Transform>();
                    Instantiate(room, yes[1].position, Quaternion.Euler(0, 0, 0));
                }
                else if (Random.Range(0, 1000) < chanceToSpawn)
                {
                    Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));
                }
            }
            else if (Random.Range(0, 1000) < chanceToSpawn && roomsSpawn < roomsGenerate)
            {
                GetDirection(i);
                _startPos = (Vector2)transform.position + (_direction * roomThiccness);

                if (!Physics2D.Raycast(_startPos, _direction, rayLenght))
                {
                    roomsSpawn++;
                    GameObject cor = Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));
                    Transform[] yes = cor.GetComponentsInChildren<Transform>();
                    Instantiate(room, yes[1].position, Quaternion.Euler(0, 0, 0));
                }
                else if (Random.Range(0, 1000) < chanceToSpawn)
                {
                    Instantiate(corridor, transform.position, Quaternion.Euler(0, 0, i * 90));
                }
            }
        }
    }
}
