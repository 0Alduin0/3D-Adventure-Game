using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterController controller;

    public float moveSpeed = 5f;

    public Vector3 movementDirection;

    public PlayerInput playerInput;

    public float verticalVelocity;
    public float gravity = -9.81f;

    public Animator animator;


    //Enemy
    public bool isPlayer = true;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Transform targetPlayer;


    //state machine
    public enum CharacterState
    {
        Normal, Attacking
    }

    public CharacterState currentState;



    private void Awake()
    {
        controller = GetComponent<CharacterController>();

        animator = GetComponent<Animator>();

        if (!isPlayer)
        {
            navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            targetPlayer = GameObject.FindWithTag("Player").transform;
            navMeshAgent.speed = moveSpeed;
        }
        else
        {
            playerInput = GetComponent<PlayerInput>();
        }
    }

    public void CalculatePlayerMovement()
    {

        if (playerInput.mouseButtonDown && controller.isGrounded)
        {
            SwitchStateTo(CharacterState.Attacking);
            return;
        }



        movementDirection.Set(playerInput.horizontalInput, 0f, playerInput.verticalInput);
        movementDirection.Normalize();
        movementDirection = Quaternion.Euler(0f, -45f, 0f) * movementDirection;
        animator.SetFloat("Speed", movementDirection.magnitude);
        movementDirection *= moveSpeed * Time.deltaTime;
        if (movementDirection != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movementDirection);

        animator.SetBool("AirBorne", !controller.isGrounded);
    }

    public void CalculateEnemyMovement()
    {
        if (Vector3.Distance(targetPlayer.position, transform.position) >= navMeshAgent.stoppingDistance)
        {
            navMeshAgent.SetDestination(targetPlayer.position);
            animator.SetFloat("Speed", 0.2f);
        }
        else
        {
            navMeshAgent.SetDestination(transform.position);
            animator.SetFloat("Speed", 0f);
        }
    }

    private void FixedUpdate()
    {
        switch (currentState)
        {
            case CharacterState.Normal:
                if (isPlayer)
                    CalculatePlayerMovement();
                else
                    CalculateEnemyMovement();
                break;

            case CharacterState.Attacking:

                break;
        }

        if (isPlayer)
        {
            if (controller.isGrounded == false)
                verticalVelocity = gravity;
            else
                verticalVelocity = gravity * 0.3f;

            movementDirection += verticalVelocity * Vector3.up * Time.deltaTime;
            controller.Move(movementDirection);
        }
    }

    public void SwitchStateTo(CharacterState newState)
    {
        //clear cache
        playerInput.mouseButtonDown = false;


        //exiting state
        switch (currentState)
        {
            case CharacterState.Normal:
                break;
            case CharacterState.Attacking:
                break;

        }

        //Entering state
        switch (newState)
        {
            case CharacterState.Normal:
                break;
            case CharacterState.Attacking:
                break;

        }
        currentState = newState;
        Debug.Log("state:" + currentState);
    }
}
