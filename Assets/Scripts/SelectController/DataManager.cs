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
    public Character currentCharacter ; //�ʱ� ������ Lizard

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            currentCharacter = Character.Lizard ;
        }
        else if (instance != null) return;

        //���� ��ȯ�Ǿ ������Ʈ�� �ı����� �ʴ´�
        DontDestroyOnLoad(gameObject); 
    }
    
}
