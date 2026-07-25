using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float timedelyaed = 0.6f;
    [SerializeField] GameObject healthrec;
    [SerializeField] GameObject[] healthbar;
    [SerializeField] AudioSource enemydeath;

    public static EnemyHealth instance;

   public int health = 4;


    public bool dropreward = true;

    Rigidbody2D rb;

    const string dead = "death";

    Animator animator;

    private void Awake()
    {
        instance = this;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void takedamage(int amount)
    {
        health -= amount;

        int currentindex = 4 - health;

        for (int i = 0; i < healthbar.Length; i++)
        {                 
           healthbar[i].SetActive(false);
        }

        if (currentindex >= 0 && currentindex < healthbar.Length)
        {
            healthbar[currentindex].SetActive(true);
        }

        if (health <= 0)
        {
            if (dropreward)
            {
             wavemanagerr.instance.enemydied();
             enemydeath.Play();
            }
            GetComponent<Enemyai>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            animator.SetTrigger(dead);
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            Invoke("delaydestroy", timedelyaed);
        }
    }

  public void delaydestroy()
    {
        if (dropreward)
        {
         Instantiate(healthrec,transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
