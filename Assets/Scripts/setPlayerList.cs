using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setPlayerList : MonoBehaviour
{
    public static List<string> playerList = new List<string>();
    public Text text;

    private void Start()
    {
        playerList.Add("¿Ë ø¿ ∑£≈œ");
        playerList.Add(PlayerPrefs.GetString("Name"));
    }
    private void Update()
    {
        string newString = "";
        for (int i = 0; i < playerList.Count; i++)
        {
            newString += playerList[i] + '\n';
        }

        text.text = newString;
    }
    
}