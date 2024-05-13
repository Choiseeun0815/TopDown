using UnityEngine;
using UnityEngine.UI;

public class CloseChangeNamebutton : ChangeNameButton
{
    public InputField getName;
    public Text playerNameTxt;
    public void CloseChangeNameUI()
    {
        string playerName = getName.text;
        PlayerPrefs.SetString("Name", playerName);

        string name = PlayerPrefs.GetString("Name");
        playerNameTxt.text = name;

        changeNameMenu.SetActive(false);
    }
}