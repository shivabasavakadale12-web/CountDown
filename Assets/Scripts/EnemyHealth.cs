using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float timedelyaed = 0.6f;
    [SerializeField] GameObject healthrec;
    [SerializeField] GameObject[] healthbar;

    int health = 4;

    const string dead = "death";

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
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
            wavemanagerr.instance.enemydied();
            animator.SetTrigger(dead);
            GetComponent<Enemyai>().enabled = false;
            Invoke("delaydestroy", timedelyaed);
        }
    }

  public void delaydestroy()
    {
        Instantiate(healthrec,transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
