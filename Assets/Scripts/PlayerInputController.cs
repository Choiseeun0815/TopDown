using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera1;

    private void Awake()
    {
        camera1 = Camera.main;
    }

    public void OnMove (InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos  = camera1.ScreenToWorldPoint(newAim);
        newAim = (worldPos -(Vector2) transform.position).normalized;

        CallLookEvent(newAim);
    }
}
