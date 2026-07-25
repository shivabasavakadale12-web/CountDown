using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{

    [SerializeField] AudioSource deathaudio;
    [SerializeField] AudioSource gameover;
    [SerializeField] GameObject gameoverui;
    [SerializeField] GameObject themeaudio;

    public  float health = 10f;
    float Protectionshield = 0.6f;
    float maxhealth = 10f;
    public static PlayerHealth instance;

    [SerializeField] Image healthbarfill;

    Animator animator;
    Rigidbody2D rb;

    Enemyai enemyai;

    private void Awake()
    {
        instance = this;    
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Takedamage(float amount)
    {
        if(shield.instance.isshield == true)
        {
            amount *= Protectionshield;
        }

        health -= amount;
      


        float normalizehealthbar = health / maxhealth;
        healthbarfill.fillAmount = Mathf.Lerp(0.2f, 1f, normalizehealthbar);
      

        if (health <= 0)
        {
            Disableenemyai();
            rb.bodyType = RigidbodyType2D.Kinematic;
            GetComponent<CapsuleCollider2D>().enabled = false;
            animator.SetTrigger("fall");
            deathaudio.Play();
            GetComponent<Movement>().enabled = false;
            Destroy(themeaudio);
            gameover.Play();
            Invoke("Scenemanagers", 2f);
        }
    }
    public void Scenemanagers()
    {
        Time.timeScale = 0f;
        gameoverui.SetActive(true);
    }

    [Obsolete]
    private static void Disableenemyai()
    {
        foreach (Enemyai ai in FindObjectsOfType<Enemyai>())
        {
            ai.enabled = false;
        }
    }

    public void UpdateHealthUI()
    {
        healthbarfill.fillAmount = health / maxhealth;
    }

}
