using System;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character = Character.Lizard;
    public SelectCharacter[] characters;
    Animator anim;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        if(DataManager.instance != null)
        {
            if (DataManager.instance.currentCharacter == character)
            {
                OnSelect();
            }
            else
            {
                OnDeSelect();
            }
        }
    }

    private void OnMouseUpAsButton()
    {
        //콜라이더를 추가해야함 !!!!!! 
        if (DataManager.instance != null)
        {
            DataManager.instance.currentCharacter = character;
            OnSelect();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] != this) characters[i].OnDeSelect();
            }
        }
    }

    private void OnDeSelect()
    {
        anim.SetBool("isWalking", false);
        spriteRenderer.color = Color.gray;
    }

    void OnSelect()
    {
        anim.SetBool("isWalking", true);
        spriteRenderer.color = Color.white;
    }    
}