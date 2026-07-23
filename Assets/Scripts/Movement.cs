using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float movespeed = 4f;

    Rigidbody2D rb;
    Vector2 movement;
    Animator animator;
    SpriteRenderer SpriteRenderer;

    const string attack = "hit";



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FixedUpdate()
    {
        handleMovement();
    }

    public void move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        Debug.Log(movement);

    }
    private void handleMovement()
    {
        float currentspeed = movespeed;

        if(Keyboard.current.leftShiftKey.isPressed)
        {
            currentspeed *= 1.6f;
        }


        Vector3 currentpostion = rb.position;
        Vector3 movedirection = new Vector3(movement.x, movement.y, 0f);
        Vector2 newpostion = currentpostion + movedirection * currentspeed * Time.deltaTime;
        rb.MovePosition(newpostion);

        bool ismoving = movement.magnitude > 0;
        animator.SetBool("walk", ismoving);
        animator.SetBool("idle", !ismoving);

        Debug.Log(movement.x);
        if (movement.x > 0f)
        {
            SpriteRenderer.flipX = true;
        }

       else if (movement.x < 0f)
        {
            SpriteRenderer.flipX = false;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            
            animator.SetTrigger(attack);
            
        }


    }
}
