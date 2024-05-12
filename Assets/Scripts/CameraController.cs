using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;
    public GameObject player;

    private void Update()
    {
        Vector2 direction = player.transform.position
            - this.transform.position;
        Vector2 moveVector = new Vector2(
            direction.x * cameraSpeed * Time.deltaTime,
            direction.y * cameraSpeed * Time.deltaTime);

        this.transform.Translate( moveVector );
    }
}