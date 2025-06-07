using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    private void Update()
    {
        horizontalInput= Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    private void OnDisable()
    {
        horizontalInput = 0f;
        verticalInput = 0f;
    }
}
