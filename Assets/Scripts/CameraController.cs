using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        Vector2 direction = player.transform.position
        - this.transform.position;
        Vector2 moveVector = new Vector2(
            direction.x * cameraSpeed * Time.deltaTime,
            direction.y * cameraSpeed * Time.deltaTime);

        this.transform.Translate(moveVector);
    }
    

}