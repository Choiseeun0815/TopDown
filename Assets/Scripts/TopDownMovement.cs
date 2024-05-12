using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private float speed = 10f;

    private TopDownController controller;
    private Rigidbody2D movementRigidbody2D;
    private Vector2 movementDirection = Vector2.zero;
    

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnLookEvent += CharacterFlip;
    }

    private void CharacterFlip(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;
        movementRigidbody2D.velocity = direction;
    }
}