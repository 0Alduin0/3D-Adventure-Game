using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterController controller;

    public float moveSpeed = 5f;

    public Vector3 movementDirection;

    public PlayerInput playerInput;

    public float verticalVelocity;
    public float gravity = -9.81f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
    }

    public void CalculateMovement()
    {
        movementDirection.Set(playerInput.horizontalInput, 0f, playerInput.verticalInput);
        movementDirection.Normalize();
        movementDirection = Quaternion.Euler(0f, -45f, 0f) * movementDirection;
        movementDirection *= moveSpeed * Time.deltaTime;
        if (movementDirection != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movementDirection);
    }

    private void FixedUpdate()
    {
        CalculateMovement();
        if (controller.isGrounded == false)
            verticalVelocity = gravity;
        else
            verticalVelocity = gravity * 0.3f;
        movementDirection += verticalVelocity * Vector3.up * Time.deltaTime;
        controller.Move(movementDirection);
    }
}
