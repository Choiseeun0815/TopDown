using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public InputField getName;
    public void startButton()
    {
        string playerName = getName.text;

        PlayerPrefs.SetString("Name", playerName);
        SceneManager.LoadScene("SampleScene");
    }
}
