using System.Collections;
using UnityEngine;

public class wavemanagerr : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] GameObject wave1text;
    public int enemydeathcounter = 0;

    float spawneroffestx;
    float spawneroffesty;
    public static wavemanagerr instance;

     void Awake()
    {
        instance = this;
    }

     void Start()
    {
        enemywaves(6);
    }

   


    public void enemywaves(int count)
    {
        for (int i = 0; i < count; i++)
        {
        spawneroffestx = Random.Range(-20f, 20f);
        spawneroffesty = Random.Range(-4f, 3f);

            Vector2 spawnpos = new Vector2(transform.position.x + spawneroffestx, transform.position.y + spawneroffesty);

            Instantiate(enemy, spawnpos, Quaternion.identity);
        }

    }
  
    public void enemydied()
    {
        enemydeathcounter++;

        if (enemydeathcounter == 6)
        {
            enemywaves(10);
        }

        if (enemydeathcounter == 16)
        {
            enemywaves(12);
        }

        if (enemydeathcounter == 28) 
        {
           //game over stuff here!
        }
    }

}
