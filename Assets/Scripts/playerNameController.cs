using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerNameController : MonoBehaviour
{
    protected GameObject player;
    public float yOffset;
    
    private void Update()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        transform.position = 
            player.transform.position + new Vector3(0, yOffset, 0);
    }

}
