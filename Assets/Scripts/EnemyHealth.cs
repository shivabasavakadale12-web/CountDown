using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float timedelyaed = 0.6f;
   

    int health = 5;

    const string dead = "death";

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void takedamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            animator.SetTrigger(dead);
            GetComponent<Enemyai>().enabled = false;
            Invoke("delaydestroy", timedelyaed);
        }
    }

  public void delaydestroy()
    {
        Destroy(gameObject);
    }
}
