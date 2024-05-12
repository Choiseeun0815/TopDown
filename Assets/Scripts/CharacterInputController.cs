using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class CharacterInputController : MonoBehaviour
{
    public InputField inputField;
    public Button button;

    private void Start()
    {
        button.interactable = false;
    }

    private void Update()
    {
        string playerName  = inputField.text;
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(playerName);

        if (!string.IsNullOrEmpty(playerName))
        {
            if (playerName.Length >= 2 && playerName.Length <= 10)
            {
                button.interactable = true;
            }
            else
            {
                button.interactable = false;
            }
        }
        else 
        {
            button.interactable = false; 
        }
    }
}