using UnityEngine;

public class DialogButton : MonoBehaviour
{
    public GameObject DialogMenu;
    public GameObject ShowDialogMenu;
    public void SetDialogUI()
    {
        Debug.Log("Click");

        ShowDialogMenu.SetActive(true);
        DialogMenu.SetActive(false);
    }

    public void CloseDialogUI()
    {
        ShowDialogMenu.SetActive(false);
    }
}