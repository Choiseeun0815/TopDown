using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameButton : MonoBehaviour
{
    [SerializeField] protected GameObject changeNameMenu;

    public void SetChangeNameUI()
    {
        changeNameMenu.SetActive(true);
    }
    
}

