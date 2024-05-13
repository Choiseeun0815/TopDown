using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Lizard, Elf
}
public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public Character currentCharacter ; //초기 세팅은 Lizard

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentCharacter = Character.Lizard ;
        }
        else if (instance != null) return;

        //씬이 전환되어도 오브젝트가 파괴되지 않는다
        DontDestroyOnLoad(gameObject); 
    }
    
}
