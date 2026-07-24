using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    int health = 10;

    Animator animator;
    Rigidbody2D rb;

    Enemyai enemyai;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Takedamage(int amount)
    {
        health -= amount;

        Debug.Log("player health: " + health);
        if (health <= 0)
        {
            Disableenemyai();

            rb.bodyType = RigidbodyType2D.Kinematic;
            GetComponent<CapsuleCollider2D>().enabled = false;
            animator.SetTrigger("fall");
            GetComponent<Movement>().enabled = false;
            Invoke("Scenemanagers", 2f);
        }
    }
    public void Scenemanagers()
    {
        SceneManager.LoadScene(0);
    }

    private static void Disableenemyai()
    {
        foreach (Enemyai ai in FindObjectsOfType<Enemyai>())
        {
            ai.enabled = false;
        }
    }


}
