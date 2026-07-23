using UnityEngine;

public class Enemyai : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float movespeed;
                     Transform target;

    Rigidbody2D rb;
    SpriteRenderer spriterenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        target = Player.transform;


        transform.position = Vector2.MoveTowards(transform.position, target.position, movespeed * Time.deltaTime);

        Vector2 direction = target.position - transform.position;
        Debug.Log(direction.x);

        if (direction.x > 0f)
        {
            spriterenderer.flipX = false;
        }
        else if (direction.x < 0f)
        {
            spriterenderer.flipX = true;
        }
    }

}
