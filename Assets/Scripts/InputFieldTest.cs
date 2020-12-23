using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputFieldTest : MonoBehaviour
{
    public Basic_Script basicScript;
    public Random_Generation_V2 generationScript;
    public GameObject room;

    public static InputFieldTest Singleton = null;

    public int yes = 0;

    private void Awake()
    {
        if (Singleton == null) Singleton = this;
        else Destroy(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        room = GameObject.Find("Room V2.0");
        generationScript = room.GetComponent<Random_Generation_V2>();

        generationScript.roomsGenerate = yes;
    }

    public void Yes(int number)
    {
        Debug.Log("called");
        yes = number;
        if (yes != 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
