using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Random_Generation : MonoBehaviour
{
    public int roomsToGenerate;

    private int _roomsSpawned;

    public float chanceToSpawnRooms;

    public GameObject room, corridor;

    

    void Start()
    {
        _roomsSpawned = 0;

        Instantiate(room, transform.position, Quaternion.identity);

        for (int i = 0; i < 4; i++)
        {
            if (Random.Range(0, 100) < chanceToSpawnRooms && _roomsSpawned < roomsToGenerate)
            {
                GenerateCorridor(i * 90, transform.position);
                _roomsSpawned++;
            } 
        }

        GenerateCorridor(90, transform.position);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(0);
        }
    }
    
    private void GenerateCorridor(float _rotation, Vector3 _location)
    {
        GameObject cor = Instantiate(corridor, _location, Quaternion.Euler(0, 0, _rotation));

        Transform[] _tran = cor.GetComponentsInChildren<Transform>();

        GenerateRoom(_tran[1].position, Quaternion.identity);
    }

    private void GenerateRoom(Vector3 _location, Quaternion _rotation)
    {
        GameObject big = Instantiate(room, _location, _rotation);
        if (_roomsSpawned < roomsToGenerate)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Random.Range(0, 100) < chanceToSpawnRooms && _roomsSpawned < roomsToGenerate)
                {
                    GenerateCorridor(transform.rotation.y + i * 90, big.GetComponent<Transform>().position);
                    _roomsSpawned++;
                }
            }
        }
    } 
}
