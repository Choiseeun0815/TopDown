using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSelectCharacter : MonoBehaviour
{  
    public GameObject[] characters;
    public GameObject player;

    int idx = (int)Character.Lizard; //ĳ���� �ʱ� ���� Lizard�� ����
    private void Start()
    {
        if (DataManager.instance!= null)
            idx = (int)DataManager.instance.currentCharacter;

        player = Instantiate(characters[idx]);
        player.transform.position  = transform.position;
    }

}
