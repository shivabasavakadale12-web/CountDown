using UnityEngine;

public class Enemyai : MonoBehaviour
{
    [SerializeField] AudioSource swordswing;
    
    Transform target;

    float movespeed;
    float attackingrange;
    float cooldown = 1f;
    float cooldowntimer = 0f;

    Rigidbody2D rb;
    SpriteRenderer spriterenderer;
    Animator animator;

  

    void Start()
    {
        movespeed = Random.Range(2f, 3.5f);
        attackingrange = Random.Range(0.85f, 1.2f);
        target = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector3 position = rb.position;
        Vector2 direction = target.position - position;
        float distance = Vector2.Distance(position, target.position);

        cooldowntimer += Time.deltaTime;

        if (distance > attackingrange)
        {       
         position = Vector2.MoveTowards(position, target.position, movespeed * Time.deltaTime);     
         rb.MovePosition (position);
        }
        else
        {
         attackplayer();
        }
        
        if (direction.x > 0f)
        {
            spriterenderer.flipX = false;
        }
        else if (direction.x < 0f)
        {
            spriterenderer.flipX = true;
        }

    }

    void attackplayer()
    {
      if(cooldown <= cooldowntimer)
      {
       swordswing.Play();
       animator.SetTrigger("attack");
       cooldowntimer = 0f;
      }
    }
}
