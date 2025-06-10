using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public bool mouseButtonDown;
    private void Update()
    {
        if (!mouseButtonDown && Time.timeScale != 0)
        {
            mouseButtonDown = Input.GetMouseButtonDown(0);
        }

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    private void OnDisable()
    {
        mouseButtonDown = false;
        horizontalInput = 0f;
        verticalInput = 0f;
    }
}
