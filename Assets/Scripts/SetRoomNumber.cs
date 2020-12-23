using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRoomNumber : MonoBehaviour
{
    private GameObject gameContr;

    public GameObject room;
    public Random_Generation_V2 randomGen;

    public void Start()
    {
        gameContr = GameObject.Find("Game Controller");
    }

    public void SetRoomNum(string num)
    {
        int rum = int.Parse(num);
        if (rum != 0)
        {
            gameContr.GetComponent<InputFieldTest>().Yes(rum);
            Debug.Log("maybe");
        }
    }
}
