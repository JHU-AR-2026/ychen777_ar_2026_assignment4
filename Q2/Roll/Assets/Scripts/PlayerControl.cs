using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private InputAction moveAction;
    private InputAction jumpAction;
    private Rigidbody rb;

    public float speed = 10f;
    public float jumpForce = 5f;

    private bool isGrounded = false;
    private bool jumpQueued = false;
    private bool gameStarted = false;

    public bool powerUpActive = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true;
    }

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    public void StartGame()
    {
        if (gameStarted)
            return;

        rb.isKinematic = false;
        rb.useGravity = true;
        gameStarted = true;
    }

    void Update()
    {
        if (!gameStarted)
            return;

        if (isGrounded && jumpAction.triggered)
            jumpQueued = true;
    }

    private void FixedUpdate()
    {
        if (!gameStarted)
            return;

        if (jumpQueued)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpQueued = false;
        }

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        Vector3 movement = new Vector3(moveValue.x, 0f, moveValue.y);
        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            isGrounded = true;
    }
}