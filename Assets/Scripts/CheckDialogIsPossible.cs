using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckDialogIsPossible : MonoBehaviour
{
    [SerializeField] private GameObject gm;
    private Transform player; 
    public Transform npc; 
    public float triggerDistance = 30f; // 대화 트리거를 활성화할 거리
    float preDistance = 0f;

    GameObject p;

    private void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
    }

    //프레임마다 계속 체크해서 대화하기가 안 되는 것 같은데...........
    void Update()
    {
        if ( p == null)
            p = GameObject.FindGameObjectWithTag("Player");

        player = p.transform;

        if (player != null)
        {
            float distance = Vector2.Distance(player.position, npc.position);

            if(preDistance != distance)
            {
                Debug.Log("hihi");
                if (distance <= triggerDistance)
                {
                    gm.SetActive(true);
                }
                else
                {
                    gm.SetActive(false);
                }
            }
            preDistance = distance;
        }

    }
    
}
