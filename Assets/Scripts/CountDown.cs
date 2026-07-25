using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] TMP_Text timetext;
    [SerializeField] GameObject endmenu;
    [SerializeField] AudioSource endaudio;

    float time = 10;

    bool endgame = false;
    void Update()
    {

        if (time > 0)
        {
            time -= Time.deltaTime;
            timetext.text = Mathf.Ceil(time).ToString("000");

        }

        if (time <= 0 && !endgame)
        {
            time = 0;
            
       
          foreach (EnemyHealth enemy in FindObjectsOfType<EnemyHealth>())
          {
                enemy.dropreward = false;
                enemy.takedamage(4);
          }

            
          Movement.instance.movespeed = 0;
          endmenu.SetActive(true);
          endaudio.Play();
          endgame = true;
        }
    }
}
