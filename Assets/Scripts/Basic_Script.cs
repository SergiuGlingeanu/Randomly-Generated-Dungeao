using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basic_Script : MonoBehaviour
{
    public int yes;
    private void Awake()
    {
        Random_Generation_V2.roomsSpawn = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene(yes);
        }
    }
}
