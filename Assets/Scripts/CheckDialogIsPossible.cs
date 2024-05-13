using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckDialogIsPossible : MonoBehaviour
{
    [SerializeField] private GameObject gm;
    private Transform player; 
    public Transform npc; 
    public float triggerDistance = 30f; // ��ȭ Ʈ���Ÿ� Ȱ��ȭ�� �Ÿ�
    float preDistance = 0f;

    GameObject p;

    private void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
    }

    //�����Ӹ��� ��� üũ�ؼ� ��ȭ�ϱⰡ �� �Ǵ� �� ������...........
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
