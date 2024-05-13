using UnityEngine;

public class ChangeCharacterButton : MonoBehaviour
{
    [SerializeField] protected GameObject changeCharacterMenu;
    public void SetChangeCharacterUI()
    {
        changeCharacterMenu.SetActive(true);
    }
}
