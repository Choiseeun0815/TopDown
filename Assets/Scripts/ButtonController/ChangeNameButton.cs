using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNameButton : MonoBehaviour
{
    public GameObject changeNameMenu;
    public void SetChangeNameUI()
    {
        changeNameMenu.SetActive(true);
    }
}
