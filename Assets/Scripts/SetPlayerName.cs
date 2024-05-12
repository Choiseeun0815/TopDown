using System;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerName : playerNameController
{
    public Text playerName;

    private void Start()
    {
        string name = PlayerPrefs.GetString("Name");
        playerName.text = name;
    }
    private void Update()
    {
        transform.position =
           character.transform.position + new Vector3(0, yOffset, 0);
    }

}