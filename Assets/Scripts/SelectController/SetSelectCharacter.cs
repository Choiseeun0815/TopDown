using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSelectCharacter : MonoBehaviour
{
    public static SetSelectCharacter Instance;
    public GameObject[] characters;
    public GameObject player;

    int idx = (int)Character.Lizard; //캐릭터 초기 값은 Lizard로 설정

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else return;
    }
    private void Start()
    {
        if (DataManager.instance!= null)
            idx = (int)DataManager.instance.currentCharacter;

        player = Instantiate(characters[idx]);
        player.transform.position = transform.position;
    }
}
