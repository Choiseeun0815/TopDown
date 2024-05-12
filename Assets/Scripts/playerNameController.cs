using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerNameController : MonoBehaviour
{
    [SerializeField] protected GameObject character;
    public float yOffset;

    private void Update()
    {
        transform.position = 
            character.transform.position + new Vector3(0, yOffset, 0);
    }

}
