using UnityEngine;

public class PlayerListButton : MonoBehaviour
{
    [SerializeField] protected GameObject playerList;

    public void showPlayerList()
    {
        playerList.SetActive(true);
    }

    public void closePlayerList()
    {
        playerList.SetActive(false);
    }
}